public static class SessionManager
{
    public static UserSession CurrentSession { get; set; }

    public static void ClearSession()
    {
        CurrentSession = null; 
    }
}