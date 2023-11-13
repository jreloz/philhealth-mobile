using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilHealth.JScriptEvaluation
{
    public static class LoginPage
    {
        public static string loginScript = @"

            var appusername = localStorage.getItem('appusername');;
            var apppassword = localStorage.getItem('apppassword');;

            var bgcolor = document.querySelector('.card.card-gradient.ui-g');
            bgcolor.classList.remove('card-gradient');

            var loginpanel = document.querySelector('.login-panel-content'); 
            loginpanel.style.marginTop = '15%';

            const bgimage = document.querySelector('.login-panel.ui-fluid');
            bgimage.style.backgroundImage = 'none';
            bgimage.style.background = 'linear-gradient(to bottom, #8CC54B, #83BC46, #5A8930)';
                    
                    
            if(appusername != '' && apppassword != ''){
                document.getElementById('loginForm:pin').value = appusername;
                document.getElementById('loginForm:password').value = apppassword;
            }else{
                document.getElementById('loginForm:pin').value = '';
                document.getElementById('loginForm:password').value = '';
            }
                   
            document.getElementById('loginForm:loginButton').addEventListener('click', function() {
                var username = document.getElementById('loginForm:pin').value;
                var password = document.getElementById('loginForm:password').value;
                localStorage.setItem('appusername', username);
                localStorage.setItem('apppassword', password);
            });



            //Remove Scrollbar
            const htmlElement = document.documentElement;
            const bodyElement = document.body;

            htmlElement.style.overflowX = 'hidden';
            bodyElement.style.overflowX = 'hidden';

            //const recaptchaButton = document.getElementById('loginForm:refresh');

            //recaptchaButton.style.backgroundColor = '#70ae45';
            //recaptchaButton.style.color = 'white';
            //recaptchaButton.style.padding = '10px 20px';
            //recaptchaButton.style.borderRadius = '5px';
            //recaptchaButton.style.cursor = 'pointer';
            //recaptchaButton.style.boxShadow = '2px 2px 5px rgba(0, 0, 0, 0.2)';

        ";
    }
}
