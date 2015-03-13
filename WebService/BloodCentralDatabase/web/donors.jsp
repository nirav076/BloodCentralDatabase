<%-- 
    Document   : donors
    Created on : 20 Oct, 2013, 3:32:13 AM
    Author     : Dell
--%>

<%@page import="bcd.Donors"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Donors</title>
        <script language="javascript" type="text/javascript" src="index.js"></script>
    </head>
    <body>
        <% 
            String message = request.getAttribute("message")==null?"":(String)request.getAttribute("message");
            String operation = request.getAttribute("operation")==null?"":(String)request.getAttribute("operation");
            Donors donor = request.getAttribute("donor")==null?null:(Donors)request.getAttribute("donor");
            
            String name = "";
            String bloodGroup = "";
            String contactNo = "";
            String address = "";
            String residentArea = "";
            String city = "";
            String state = "";
            String availability = "";
            String lastDonated = "";
            String associatedWith = "";
            
            String output="";
            
            if(donor!=null)
            {
                name = donor.getName();
                bloodGroup = donor.getBloodgroup();
                contactNo = donor.getContact();
                address = donor.getAddress();
                residentArea = donor.getResidentialArea();
                city = donor.getCity();
                state = donor.getState();
                availability = donor.getAvailability();
                lastDonated = donor.getLastDonated();
                associatedWith = donor.getAssociatedWith().getName();
                output = name+","+bloodGroup+","+contactNo+","+address+","+residentArea+","+city+","+state+","+availability+","+lastDonated+","+associatedWith;
            }
            
        %>
        
        <h1>Welcome Donors</h1>
        <%= operation %>
        <%= message %>
        <%= output %>
        <form name="donors" method="post" action="DonorsServlet" onsubmit=""> 
        <table border="0">
            <tr>
                <td>Name</td>
                <td><input type="text" name="name" id="name" value=""/></td>
                <td colspan="1"><div id="nameMsg"></div></td>
            </tr>
            
            <tr>
                <td>Blood Group</td>
                <td>
                    <select name="bloodGroup" id="bloodGroup">
                        <option>A+</option>
                        <option>A-</option>
                        <option>B+</option>
                        <option>B-</option>
                        <option>AB+</option>
                        <option>AB-</option>
                        <option>O+</option>
                        <option>O-</option>
                    </select>    
                        
                </td>
                <td><div id="bgMsg" colspan="1"></div></td>
            </tr>
            
            <tr>
                <td>Contact No.</td>
                <td><input type="text" name="contactNo" id="contactNo" value=""/></td>
                <td><div id="cMsg" colspan="1"></div></td>
            </tr>
            
            <tr>
                <td>Address</td>
                <td><textarea name="address" id="address" value=""></textarea></td>
                <td><div id="addMsg" colspan="1"></div></td>
            </tr>
            
            <tr>
                <td>Resident Area</td>
                <td><input type="text" name="residentArea" id="residentArea" value=""/></td>
                <td><div id="raMsg" colspan="1"></div></td>
            </tr>
            
            <tr>
                <td>City</td>
                <td><input type="text" name="city" id="city" value=""/></td>
                <td><div id="cityMsg" colspan="1"></div></td>
            </tr>
            
            <tr>
                <td>State</td>
                <td><input type="text" name="state" id="state" value=""/></td>
                <td><div id="stateMsg" colspan="1"></div></td>
            </tr>
            
            <tr>
                <td>Availability</td>
                <td>
                    <select name="availability" id="availability"/>
                        <option>Morning</option>
                        <option>Afternoon</option>
                        <option>Evening</option>
                        <option>Night</option>
                        <option>Any Time</option>
                </td>
                <td><div id="availMsg" colspan="1"></div></td>
            </tr>
            <tr>
                <td>Last Donated</td>
                <td><input type="text" name="lastDonated" id="lastDonated" value=""/></td>
                <td><div id="ldMsg" colspan="1"></div></td>
            </tr>
            
            <tr>
                <td>Associated With</td>
                <td><input type="text" name="associatedWith" id="associatedWith" value=""/></td>
                <td><div id="awMsg" colspan="1"></div></td>
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
    </body>
</html>
