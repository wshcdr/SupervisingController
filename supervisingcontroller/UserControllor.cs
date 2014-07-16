using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supervisingcontroller
{
    public class UserControllor
    {
        public IView View;

        public User Model;


        public UserControllor(UserView view)
        {
            Model = new User() { ID = "1", Name = "test" };
            this.View = view;
            this.View.UpdateId += OnUpdateId;
            this.View.UpdateName += new Action(View_UpdateName);
        }



        /// <summary>
        /// 
        /// </summary>
        public void UpdateUser()
        {
            Persist(Model);
        }

        private void Persist(User user)
        {

            System.Windows.Forms.MessageBox.Show("ID:" + user.ID + " Name:" + user.Name);
        }

        private void OnUpdateId() {
            this.UpdateUser();
        }

        private void View_UpdateName()
        {
            this.UpdateUser();
        }
    }
}
