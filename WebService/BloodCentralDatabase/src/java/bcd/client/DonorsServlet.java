/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package bcd.client;

import bcd.Bloodbanks;
import bcd.Donors;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author Dell
 */
public class DonorsServlet extends HttpServlet {
    
    ResourceClient donorClient = new ResourceClient("donors");
    ResourceClient bankClient = new ResourceClient("bloodbanks");
    
    protected static Donors getDonor(HttpServletRequest request, ResourceClient donorClient, Bloodbanks bank)
    {
        Donors donor = new Donors();
        String name = request.getParameter("name");
        
        String id = name.substring(0, 3).toUpperCase();
        String getId=id;
        for(int i = 1; i<100 ; i++)
        {
            id = getId;
            if(i<10)
                id = id+"00"+i;
            else if(i>=10 && i<100)
                id = id+"0"+i;
            donor = donorClient.find_XML(Donors.class, id);
            
            if(donor == null)
            {
                break;
            }
        }
        
        donor = new Donors();
        
        System.out.println("id:"+id);
        donor.setName(name);
        donor.setId(id);
        donor.setBloodgroup(request.getParameter("bloodGroup"));
        donor.setContact(request.getParameter("contactNo"));
        donor.setAddress(request.getParameter("address"));
        donor.setResidentialArea(request.getParameter("residentArea"));
        donor.setCity(request.getParameter("city"));
        donor.setState(request.getParameter("state"));
        donor.setAvailability(request.getParameter("availability"));
        donor.setLastDonated(request.getParameter("lastDonated"));
        donor.setAssociatedWith(bank);
        
        return donor;
    }

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        
        Donors donor = new Donors();
        
        
        String message="";
        String id="";
        int count;
        String operation = (String)request.getParameter("operation");
        System.out.println(operation); 
        RequestDispatcher rd = request.getRequestDispatcher("donors.jsp");
     
        
        switch(operation)
        {
            case "Create":      request.setAttribute("operation", "GetAssociatedWith");
                                String associatedWith = request.getParameter("associatedWith");
                                System.out.println("assoWith:"+associatedWith);
                                request.setAttribute("associatedId", associatedWith);
                                request.getRequestDispatcher("BloodBankServlet").include(request, response);
                                Bloodbanks bank = new Bloodbanks();
                                bank = (Bloodbanks)request.getAttribute("bank");
                                System.out.println(bank.getName());
                                donor = DonorsServlet.getDonor(request,donorClient,bank);
                                count = Integer.parseInt(donorClient.countREST());
                                donorClient.create_XML(donor);
                                if(count == Integer.parseInt(donorClient.countREST()))
                                {
                                    message = "Something went wrong, your Record is not inserted!!";
                                }
                                else message = "Record Inserted!!";
                                request.setAttribute("operation", operation);
                                request.setAttribute("message", message);
                                rd.forward(request, response);
                                break;
            case "Retrieve":    request.setAttribute("operation", operation);
                                String name = request.getParameter("name");
                                String area = request.getParameter("residentArea");
                                id = name.substring(0, 3).toUpperCase();
                                String getId=id;
                                for(int i = 1; i<100 ; i++)
                                {
                                    id = getId;
                                    if(i<10)
                                        id = id+"00"+i;
                                    else if(i>=10 && i<100)
                                        id = id+"0"+i;
                                    donor = donorClient.find_XML(Donors.class, id);
                                    if(donor == null)
                                    {
                                        break;
                                    }
                                    else if(donor.getResidentialArea().equals(area) && donor.getName().equals(name))
                                    {
                                        break;
                                    }
                                }
                                
                                if(donor == null)
                                {
                                    message = "Record not Found!!";
                                }
                                else 
                                {
                                    message = "Record Found!!";
                                }
                                request.setAttribute("message", message);
                                request.setAttribute("donor", donor);
                                rd.forward(request, response);
                                break;
            case "Update":      request.setAttribute("operation", operation);
                                rd.forward(request, response);
                                break;
            case "Delete":      request.setAttribute("operation", operation);
                                rd.forward(request, response);
                                break;
        }
        
    
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
