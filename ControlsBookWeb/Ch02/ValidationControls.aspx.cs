// Title: Building ASP.NET Server Controls
//
// Chapter: 2 - Server Control Basics
// File: ValidationControls.aspx.cs
// Written by: Dale Michalk and Rob Cameron
//
// Copyright � 2003, Apress L.P.
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ControlsBookWeb.Ch02
{
   public class ValidationControls : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.Label Label1;
      protected System.Web.UI.WebControls.Label Label2;
      protected System.Web.UI.WebControls.Label Label3;
      protected System.Web.UI.WebControls.Label Label4;
      protected System.Web.UI.WebControls.Label Label5;
      protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
      protected System.Web.UI.WebControls.Button Button1;
      protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
      protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
      protected System.Web.UI.WebControls.CustomValidator CustomValidator1;
      protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
      protected System.Web.UI.WebControls.RangeValidator RangeValidator1;
      protected System.Web.UI.WebControls.TextBox RequiredField;
      protected System.Web.UI.WebControls.TextBox ComparedField;
      protected System.Web.UI.WebControls.TextBox RangeField;
      protected System.Web.UI.WebControls.TextBox RegexField;
      protected System.Web.UI.WebControls.TextBox CustomField;
      protected System.Web.UI.WebControls.Label ResultsLabel;

      private void Page_Load(object sender, System.EventArgs e)
      {

      }
      
      #region Web Form Designer generated code
      override protected void OnInit(EventArgs e)
      {
         //
         // CODEGEN: This call is required by the ASP.NET Web Form Designer.
         //
         InitializeComponent();
         base.OnInit(e);
      }

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.CustomValidator1.ServerValidate += new System.Web.UI.WebControls.ServerValidateEventHandler(this.ValidateEven);
         this.Button1.Click += new System.EventHandler(this.Button1_Click);
         this.Load += new System.EventHandler(this.Page_Load);

      }
      #endregion
      
      private void Button1_Click(object sender, System.EventArgs e)
      {
         ResultsLabel.Text = "Page submitted at " + DateTime.Now + " IsValid:" + Page.IsValid;
      }

      private void ValidateEven(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
      {
         if ((Convert.ToInt32(args.Value) % 2) == 0)
            args.IsValid = true;
         else
            args.IsValid = false;
      }
   }
}
