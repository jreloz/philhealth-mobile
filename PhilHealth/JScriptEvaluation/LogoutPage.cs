
namespace PhilHealth.JScriptEvaluation
{
    public static class LogoutPage
    {
        public static string logoutScript = @"
            const bgimage = document.querySelector('.card.login-panel.ui-fluid');
            bgimage.style.backgroundImage = 'none';
            bgimage.style.background = 'linear-gradient(to bottom, #8CC54B, #83BC46, #5A8930)';
        ";



    }
}
