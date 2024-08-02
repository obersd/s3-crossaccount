using Amazon.Runtime;
using Amazon.S3.Transfer;

var credentials = new BasicAWSCredentials("ak", "sk");
var s3Client = new Amazon.S3.AmazonS3Client(credentials, Amazon.RegionEndpoint.USEast1);
var bucketName = "my-public-bucket-store";
var ftu = new TransferUtility(s3Client);
await ftu.UploadAsync("test.png", bucketName);
Console.WriteLine("OK");
