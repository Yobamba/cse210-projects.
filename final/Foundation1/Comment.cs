public class Comment 
{
    private string _nameOfCommenter;
    private string _commentTxt;

    public Comment() 
    {

    }
    public Comment(string nameOfCommenter, string commentTxt) 
    {
        _nameOfCommenter = nameOfCommenter;
        _commentTxt = commentTxt;
    }

    public Comment CreateComment(string nameOfCommenter, string commentTxt) 
    {
        Comment comentario = new Comment(nameOfCommenter, commentTxt);

        return comentario;

    }

}