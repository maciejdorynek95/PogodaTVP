using PogodaTVP.Logic.Interfaces;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace PogodaTVP.Logic.Services
{
    public  class FileService : IFileService
    {
        public FileInfo ChangeFileExtensionToMogrt(FileInfo fullFileName)
        {           
            var file = new FileInfo(fullFileName.FullName.Replace(".zip", ".mogrt"));
           

            if (File.Exists(fullFileName.FullName))
            {
                if (File.Exists(file.FullName))               
                    File.Delete(file.FullName);

                File.Move(fullFileName.FullName, file.FullName);
                if (File.Exists(file.FullName))
                {
                    File.Delete(fullFileName.FullName);
                    return new FileInfo(fullFileName.FullName);
                }
                throw new FileNotFoundException($"Nie udało się zmienić rozszerzenia pliku : {fullFileName.FullName} do  {file.FullName}");
            }
            return null;
        }

        public FileInfo CreateFileFromHttpResponse(HttpWebResponse httpWebResponse)
        {
            string fileFolder = "Pogoda";
            string fileNameSufix = DateTime.Now.Date.ToShortDateString() + "_" + Guid.NewGuid();
            string fileExtension = ".zip";
            var fileInfo = new FileInfo($@"{fileFolder}\fileWeather_{fileNameSufix}_{fileExtension}");

   

            using (Stream output = File.OpenWrite(fileInfo.FullName))
            using (Stream input = httpWebResponse.GetResponseStream())
            {
                input.CopyTo(output);
            }
            if (!File.Exists(fileInfo.FullName))
            {
                throw new FileNotFoundException($"Error when creating Weather file from Cumulus {fileInfo.FullName}");
            }
            return fileInfo;
        }

        public FileInfo ExtractFile(FileInfo fullFileName)
        {
            string unpackDirectory = fullFileName.Directory + @$"\{DateTime.Now.Date.ToShortDateString()}";
            using (ZipArchive archive = ZipFile.Open(fullFileName.FullName, ZipArchiveMode.Update))
            {
                Directory.CreateDirectory(unpackDirectory);
                var fileInZip = archive.Entries[0].Name;
                var pathToExtractedFileFromZip = unpackDirectory + "\\" + fullFileName.Name.Replace($"_{fullFileName.Extension}", "");
                archive.ExtractToDirectory(pathToExtractedFileFromZip, true);

                return new FileInfo(pathToExtractedFileFromZip + "\\" + fileInZip);

            }
        }

        public FileInfo ZippFile(FileInfo fileToZipping)
        {
            var newZipFile = new FileInfo(fileToZipping.Directory.FullName + ".zip");
            var newMogrtFile = new FileInfo(fileToZipping.Directory.FullName + ".mogrt");
            try
            {
                if (!Directory.Exists(newZipFile.Directory.FullName))
                {
                    newZipFile.Directory.Create();
                }

                if (File.Exists(newZipFile.FullName))
                {
                    newZipFile.Delete();
                }

                if (File.Exists(newMogrtFile.FullName))
                {
                    newMogrtFile.Delete();
                }


                ZipFile.CreateFromDirectory(fileToZipping.Directory.FullName, newZipFile.FullName, CompressionLevel.NoCompression, false);

                if (File.Exists(newZipFile.FullName))
                {
                    // Remove temp folder
                    fileToZipping.Directory.Delete(true);
                    return newZipFile;
                }
                throw new FileNotFoundException($"Błąd podczas generowania pliku : {newZipFile.Name}");
            }
            catch (Exception)
            {

                throw;
            }              
        }


        private FileInfo CreateTempFile(FileInfo sourceFile, string json)
        {
            var tempFile = new FileInfo(sourceFile.FullName.Replace(sourceFile.Extension, "temp"));
            File.WriteAllText(tempFile.FullName, json);
            return tempFile;
        }

    }
}
