using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class User
    {
        public string firstname 
        { get; set; }
        
        public string lastname
        { get; set; }
        

       
        public virtual void register() {
            // Register   
        }
        public virtual void showProfil()
        {
            // Show Profil
        }
        public virtual void editProfil()
        {
            //edit Profil
        }

    }
}
