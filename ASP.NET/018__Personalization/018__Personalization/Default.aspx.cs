using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Profile;

namespace _018__Personalization
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ProfileCommon pc = this.Profile.GetProfile(Profile.UserName);

                if (pc != null)
                {
                    this.txtbxName.Text = pc.Name;
                    this.txtbxStreet.Text = pc.Address.Street;
                    this.txtbxCity.Text = pc.Address.City;
                    this.txtbxState.Text = pc.Address.State;
                    this.txtbxZipCode.Text = pc.Address.Zipcode;
                    this.clndrDOB.SelectedDate = pc.Birthday;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProfileCommon pc = this.Profile.GetProfile(Profile.UserName);

            if (pc != null)
            {
                pc.Name = this.txtbxName.Text;
                pc.Address.Street = this.txtbxStreet.Text;
                pc.Address.City = this.txtbxCity.Text;
                pc.Address.State = this.txtbxState.Text;
                pc.Address.Zipcode = this.txtbxZipCode.Text;
                pc.Birthday = this.clndrDOB.SelectedDate;

                pc.Save();
            }
        }
    }
}