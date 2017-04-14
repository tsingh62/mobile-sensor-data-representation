<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webgraphs.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
<asp:Chart ID="Chart1" runat="server" >
<Legends>
<asp:Legend Alignment="Center" Docking="Bottom" Name="Dotnet Chart Example" />
</Legends>
<Series>
<asp:Series Name="x value" ChartType="Line" />
    <asp:Series ChartArea="ChartArea1" Legend="Dotnet Chart Example" Name="y value" ChartType="Line">
    </asp:Series>
    <asp:Series ChartArea="ChartArea1" Legend="Dotnet Chart Example" Name="z value" ChartType="Line">
    </asp:Series>
</Series>
<ChartAreas>
<asp:ChartArea Name="ChartArea1" />
</ChartAreas>
    <Titles>
        <asp:Title Name="Title1" Text="Accelerometer">
        </asp:Title>
    </Titles>
</asp:Chart>
                    </asp:TableCell>
                <asp:TableCell>
                    <asp:Chart ID="Chart2" runat="server" >
<Legends>
<asp:Legend Alignment="Center" Docking="Bottom" Name="Dotnet Chart Example" />
</Legends>
<Series>
<asp:Series Name="x value" ChartType="Line" />
    <asp:Series ChartArea="ChartArea2" Legend="Dotnet Chart Example" Name="y value" ChartType="Line">
    </asp:Series>
    <asp:Series ChartArea="ChartArea2" Legend="Dotnet Chart Example" Name="z value" ChartType="Line">
    </asp:Series>
</Series>
<ChartAreas>
<asp:ChartArea Name="ChartArea2" />
</ChartAreas>
    <Titles>
        <asp:Title Name="Title1" Text="Magnetometer">
        </asp:Title>
    </Titles>
</asp:Chart>
                </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Chart ID="Chart3" runat="server" >
<Legends>
<asp:Legend Alignment="Center" Docking="Bottom" Name="Dotnet Chart Example" />
</Legends>
<Series>
<asp:Series Name="light value" ChartType="Line" />
   
</Series>
<ChartAreas>
<asp:ChartArea Name="ChartArea3" />
</ChartAreas>
    <Titles>
        <asp:Title Name="Title1" Text="Light Sensor">
        </asp:Title>
    </Titles>
</asp:Chart>
                </asp:TableCell>
        <asp:TableCell>
              <asp:Button ID ="btn" runat="server" Text="Load Results" OnClick="btn_Click" />
        </asp:TableCell>        
            </asp:TableRow>

            </asp:Table>
</div>
      

    </div>
    </form>
</body>
</html>
