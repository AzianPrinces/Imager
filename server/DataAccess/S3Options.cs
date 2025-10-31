namespace DataAccess;

public class S3Options
{
    public string AwAccessKeyId { get; set; } = null;
    public string AwEndpointUrlS3 { get; set; } = null;
    public string AwSecretAccessKey { get; set; } = null;
    public string BucketName { get; set; } = null;
}