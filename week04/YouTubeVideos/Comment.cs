using System.Security.Cryptography.X509Certificates;

public class Comment
{
    private string _CommenterName;
    private string _Text;

    public string GetCommenterName()
    {
        return _CommenterName;
    }
    public string GetText()
    {
        return _Text;
    }

    public Comment(string commenterName, string text)
    {
        _CommenterName = commenterName;
        _Text = text;
    }
}