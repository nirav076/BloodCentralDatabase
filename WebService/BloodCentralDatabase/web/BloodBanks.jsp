<%-- 
    Document   : index.jsp
    Created on : 19 Oct, 2013, 8:53:27 PM
    Author     : Dell
--%>

<%@page import="bcd.Bloodbanks"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Blood Bank Database</title>
        <script language="javascript" type="text/javascript" src="index.js"></script>
    </head>
    <body>
        <% 
            String operation = request.getAttribute("operation")==null?"":(String)request.getAttribute("operation"); 
            String message = request.getAttribute("message")==null?"":(String)request.getAttribute("message");
            Bloodbanks bank = request.getAttribute("bank")==null?null:(Bloodbanks)request.getAttribute("bank");
            
            String id = "";
            String name= "";
            String address= "";
            String area= "";
            String city= "";
            String state= "";
            String contactDetails= "";
            String incharge= "";
            String a1nve= "";
            String a1pve= "";
            String a1bnve= "";
            String a1bpve= "";
            String a2nve= "";
            String a2pve= "";
            String a2bnve= "";
            String a2bpve= "";
            String bnve= "";
            String bpve= "";
            String b1pve= "";
            String onve= "";
            String opve= "";
            
            if(bank != null)
            {
                  id=  bank.getId();
                  name=  bank.getName();
                  address=  bank.getAddress();
                  area=  bank.getArea();
                  city=  bank.getCity();
                  state=  bank.getState();
                  contactDetails =  bank.getContactDetails();
                  incharge=  bank.getIncharge();
                  a1nve =  Integer.toString(bank.getA1nve());
                  a1pve =  Integer.toString(bank.getA1pve());
                  a1bnve =  Integer.toString(bank.getA1Bnve());
                  a1bpve =  Integer.toString(bank.getA1Bpve());
                  a2nve =  Integer.toString(bank.getA2nve());
                  a2pve =  Integer.toString(bank.getA2pve());
                  a2bnve =  Integer.toString(bank.getA2Bnve());
                  a2bpve =  Integer.toString(bank.getA2Bpve());
                  bnve =  Integer.toString(bank.getBnve());
                  bpve =  Integer.toString(bank.getBpve());
                  b1pve =  Integer.toString(bank.getB1pve());
                  onve =  Integer.toString(bank.getOnve());
                  opve =  Integer.toString(bank.getOpve());
            }
          
        %>
        <h1>Blood Banks</h1>
        <%= operation %></br>
         <%= message %>
        <form name="bloodBank" method="post" action="BloodBankServlet" onsubmit="return checkForm()"> 
        <table border="0">
            <tr>
                <td>Blood Bank Name</td>
                <td><input type="text" name="name" id="name" value="<%= name %>"/></td>
                <td colspan="4"><div id="nameMsg"></div></td>
            </tr>
            
            <tr>
                <td>Address</td>
                <td><textarea name="address" id="address" cols="20" rows="5"><%= address %></textarea></td>
                <td><div id="addMsg" colspan="4"></div></td>
            </tr>
            
            <tr>
                <td>Area</td>
                <td><input type="text" name="area" id="area" value="<%= area %>"/></td>
                <td><div id="areaMsg" colspan="4"></div></td>
            </tr>
            
            <tr>
                <td>City</td>
                <td><input type="text" name="city" id="city" value="<%= city %>"/></td>
                <td><div id="cityMsg" colspan="4"></div></td>
            </tr>
            
            <tr>
                <td>State</td>
                <td><input type="text" name="state" id="state" value="<%= state %>"/></td>
                <td><div id="stateMsg" colspan="4"></div></td>
            </tr>
            
            <tr>
                <td>Contact Details</td>
                <td><input type="text" name="contactDetails" id="contactDetails" value="<%= contactDetails %>"/></td>
                <td><div id="Msg" colspan="4"></div></td>
            </tr>
            
            <tr>
                <td>Incharge Person</td>
                <td><input type="text" name="incharge" id="incharge" value="<%= incharge %>"/></td>
                <td><div id="incMsg" colspan="4"></div></td>
            </tr>
            
            <tr>
                <td>A1-ve</td>
                <td><input type="text" name="a1-ve" id="a1-ve" size="5" value="<%= a1nve %>"/></td>
                <td><div id="a1-veMsg"></div></td>
                
                <td>A1+ve</td>
                <td><input type="text" name="a1+ve" id="a1+ve" size="5" value="<%= a1pve %>"/></td>
                <td><div id="a1+veMsg"></div></td>
            </tr>
            
            <tr>
                <td>A1B-ve</td>
                <td><input type="text" name="a1b-ve" id="a1b-ve" size="5" value="<%= a1bnve %>"/></td>
                <td><div id="a1b-veMsg"></div></td>
            
                <td>A1B+ve</td>
                <td><input type="text" name="a1b+ve" id="a1b+ve" size="5" value="<%= a1bpve %>"/></td>
                <td><div id="a1b+veMsg"></div></td>
            </tr>
            
            <tr>
                <td>A2-ve</td>
                <td><input type="text" name="a2-ve" id="a2-ve" size="5" value="<%= a2nve %>"/></td>
                <td><div id="a2-veMsg"></div></td>
            
                <td>A2+ve</td>
                <td><input type="text" name="a2+ve" id="a2+ve" size="5" value="<%= a2pve %>"/></td>
                <td><div id="a2+veMsg"></div></td>
            </tr>
            
            <tr>
                <td>A2B-ve</td>
                <td><input type="text" name="a2b-ve" id="a2b-ve" size="5" value="<%= a2bnve %>"/></td>
                <td><div id="a2b-veMsg"></div></td>
            
                <td>A2B+ve</td>
                <td><input type="text" name="a2b+ve" id="a2b+ve" size="5" value="<%= a2bpve %>"/></td>
                <td><div id="a2b+veMsg"></div></td>
            </tr>
            
            <tr>
                <td>B-ve</td>
                <td><input type="text" name="b-ve" id="b-ve" size="5" value="<%= bnve %>"/></td>
                <td><div id="b-veMsg"></div></td>
            
                <td>B+ve</td>
                <td><input type="text" name="b+ve" id="b+ve" size="5" value="<%= bpve %>"/></td>
                <td><div id="b+veMsg"></div></td>
            
            </tr>
            
            <tr>
                <td>B1+ve</td>
                <td><input type="text" name="b1+ve" id="b1+ve" size="5" value="<%= b1pve %>"/></td>
                <td><div id="b1+veMsg"></div></td>
        
                <td>O-ve</td>
                <td><input type="text" name="o-ve" id="o-ve" size="5" value="<%= onve %>"/></td>
                <td><div id="o-veMsg"></div></td>
            
            <tr>
                <td>O+ve</td>
                <td><input type="text" name="o+ve" id="b+ve" size="5" value="<%= opve %>"/></td>
                <td><div id="o+veMsg"></div></td>
            </tr>
            <tr>
                <td align="center" colspan="6">
                    <input type="SUBMIT" name="retrieve" id="retrieve" value="Retrieve" onclick="setoperation(this.value)"/>
                    <input type="SUBMIT" name="create" id="create" value="Create" onclick="setoperation(this.value)"/>
                    <input type="SUBMIT" name="update" id="update" value="Update" onclick="setoperation(this.value)"/>
                    <input type="SUBMIT" name="delete" id="delete" value="Delete" onclick="setoperation(this.value)"/>
                </td>
            </tr>
        </table>
            <input type="hidden" name="operation" id="operation"/>
        </form>
                <a href="donors.jsp">Donors</a>
    </body>
</html>
