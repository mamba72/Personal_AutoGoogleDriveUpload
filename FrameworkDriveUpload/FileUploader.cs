using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Google.Apis.Drive.v3;

namespace WFDriveUpload
{
    class FileUploader
    {

        public static bool UploadSimple(string fileName)
        {
            Google.Apis.Drive.v3.DriveService driveService = new DriveService();

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "myTestPhoto.jpg"
            };

            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(fileName,
                                    System.IO.FileMode.Open))
            {
                request = driveService.Files.Create(
                    fileMetadata, stream, "image/jpeg");
                request.Fields = "id";
                request.Upload();
            }
            var file = request.ResponseBody;
            Console.WriteLine("File ID: " + file.Id);




            return false;
        }


    }
}
