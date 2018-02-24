using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using BusinessLogic;
using DataAccess;

namespace Pratice3TierApp
{
    public partial class First : System.Web.UI.Page
    {
        string Output = string.Empty;
            
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
           
                UserBO bo = new UserBO();
                bo.Name = txtname.Text;
                bo.Address = txAddress.Text;
                bo.EmailID = txtEmailid.Text;
                bo.Mobilenumber = txtmobile.Text;

                UserBL ubl = new UserBL();
                Output = Convert.ToString(ubl.SaveUserregisrationBL(bo));

            
        }
    }
}