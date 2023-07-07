namespace DevFreela.Core.Exceptions;

public class ProjectAlreadyStartedException : Exception
{
    public ProjectAlreadyStartedException() :
        base("O projeto já foi Iniciado!")
    {
    }
}
