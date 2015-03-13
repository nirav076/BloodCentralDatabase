<%-- 
    Document   : index
    Created on : 20 Oct, 2013, 12:54:56 PM
    Author     : SONY
--%>

<%@page import="java.lang.reflect.Method"%>
<%@page import="java.util.List"%>
<%@page import="java.util.ArrayList"%>
<%@page import="bcd.Bloodbanks"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <script language="javascript" type="text/javascript" src="index.js"></script>
        <link rel="stylesheet" href="index.css" type="text/css"/>
        <title>Blood Central Database</title>
    </head>
    <body>
        <%
            List <Bloodbanks> banks = new ArrayList();
            banks = request.getAttribute("banks")==null?null:(List<Bloodbanks>)request.getAttribute("banks");
            String id = "";
            String name= "";
            String address= "";
            String area= "";
            String city= "";
            String state= "";
            String contactDetails= "";
            String incharge= "";
            String bloodGroup = request.getAttribute("bloodGroup")==null? "" :(String)request.getAttribute("bloodGroup");
        %>
        <div id="bloodImg"><img src="blood.jpg"/></div>
        <div id="heading"><font size="15" font-family="helvetica"> Welcome to Central Database of Blood Banks and Donors</font></div>
        <div id="bloodBanksLink"><a href="BloodBanks.jsp">BloodBanks</a></div>
        <div id="donorsLink"><a href="donors.jsp">Donors</a></div>
        
        <br/>
        <br/>
        
        <div id="theForm">
        <form name="getBloodUnits" id="getBloodUnits" method="POST" action="BloodBankServlet">
            Get available blood units in different blood banks.<br/>
            Blood Group:
            <select name="bloodGroup" id ="bloodGroup">
                <option value="A1nve">A1-ve</option>
                <option value="A1pve">A1+ve</option>
                <option value="A1bnve">A1B-ve</option>
                <option value="A1bpve">A1B+ve</option> 
                <option value="A2nve">A2-ve</option>
                <option value="A2pve">A2+ve</option>
                <option value="A2bnve">A2B-ve</option>
                <option value="A2bpve">A2B+ve</option>
                <option value="Bnve">B-ve</option>
                <option value="Bpve">B+ve</option>
                <option value="B1pve">B1+ve</option>
                <option value="Onve">O-ve</option>
                <option value="Opve">O+ve</option>
            </select>     
            <input type="submit" name="GetUnits" id="getUnits" value="GetUnits" onclick="setoperation(this.value)"/>    
            <input type="hidden" name="operation" id="operation"/>
        </form>
        </div>
        <div id="bloodUnits" name="bloodUnits">
            <%
                if(banks != null)
                {
            %> 
            <table border="1">
                    <tr>
                        <th>Name</th>
                        <th>Address</th>
                        <th>Area</th>
                        <th>City</th>
                        <th>State</th>
                        <th>Contact Details</th>
                        <th>Incharge</th>
                        <th>No. of Units of <%= bloodGroup %></th>
                    </tr>
            <%
                int i=0;
                for(Bloodbanks bank: banks)
                {
                    i++;
                    name = bank.getName();
                    address= bank.getAddress();
                    area= bank.getArea();
                    city= bank.getCity();
                    state= bank.getState();
                    contactDetails= bank.getContactDetails();
                    int no = 0;
                    incharge= bank.getIncharge();
                    if(bloodGroup.equals("A1nve"))
                            no = bank.getA1nve();
                    else if(bloodGroup.equals("A1pve"))
                        no = bank.getA1pve();
                    else if(bloodGroup.equals("A1bnve"))
                            no = bank.getA1Bnve();
                    else if(bloodGroup.equals("A1bpve"))
                        no = bank.getA1Bpve();
                    else if(bloodGroup.equals("A2nve"))
                                        break;
                    else if(bloodGroup.equals("A2pve"))
                            no = bank.getA2pve();
                    else if(bloodGroup.equals("A2bnve"))
                        no = bank.getA2Bnve();
                    else if(bloodGroup.equals("A2bpve"))
                            no = bank.getA2Bpve();
                    else if(bloodGroup.equals("Bnve"))
                            no = bank.getBnve();
                    else if(bloodGroup.equals("Bpve"))
                            no = bank.getBpve();
                    else if(bloodGroup.equals("B1pve"))
                        no = bank.getB1pve();
                    else if(bloodGroup.equals("Onve"))
                        no = bank.getOnve();
                    else if(bloodGroup.equals("Opve"))
                        no = bank.getOpve();
                
                %>
                
                    <tr>
                        <td><%= name %></td>
                        <td><%= address %></td>
                        <td><%= area %></td>
                        <td><%= city %></td>
                        <td><%= state %></td>
                        <td><%= contactDetails %></td>
                        <td><%= incharge %></td>
                        <td><%= no %></td>
                    </tr>
                   <% } 
            }
                   %>
                </table>
            </div>
    </body>
</html>
