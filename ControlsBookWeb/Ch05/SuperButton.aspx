<%@ Page language="c#" Codebehind="SuperButton.aspx.cs" AutoEventWireup="false" Inherits="ControlsBookWeb.Ch05.SuperButton" %>
<%@ Register TagPrefix="apress" Namespace="ControlsBookLib.Ch05" Assembly="ControlsBookLib" %>
<%@ Register TagPrefix="apressUC" TagName="ControlsBookHeader" Src="..\ControlsBookHeader.ascx" %>
<%@ Register TagPrefix="apressUC" TagName="ControlsBookFooter" Src="..\ControlsBookFooter.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>Ch05 SuperButton</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="FlowLayout">
    <form id="SuperButton" method="post" runat="server">
      <apressUC:ControlsBookHeader id="Header" runat="server" ChapterNumber="5" ChapterTitle="Event-based Programming" />
      <h3>Ch05 SuperButton</h3>
      <apress:superbutton id="superbtn" runat="server" Text="SuperButton Button"></apress:superbutton><br>
      <br>
      <apress:superbutton display="hyperlink" id="superlink" runat="server" Text="SuperButton HyperLink"></apress:superbutton><br>
      <br>
      <h3><asp:Label id="ClickLabel" runat="server">Waiting...</asp:Label></h3>
      <apressUC:ControlsBookFooter id="Footer" runat="server" />
    </form>
  </body>
</HTML>
