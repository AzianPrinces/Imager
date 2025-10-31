using Amazon.S3;

namespace DataAccess;

public class S3Service
{
        
    public S3Service(S3Options options)
    {
        var s3Client = new AmazonS3Client(
            options.AwsAccessKeyId,
            options.AwsSecretAccessKey,
            new AmazonS3Config { ServiceURL = options.AwsEndpointUrlS3, UseHttp = false }
        );
    }
    
   
    
}