/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package bcd.client;

import bcd.Bloodbanks;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.ws.rs.core.GenericType;
import javax.ws.rs.core.Response;

/**
 *
 * @author Dell
 */
public class BloodBankServlet extends HttpServlet {
    
    ResourceClient bloodClient = new ResourceClient("bloodbanks");
    
    protected static Bloodbanks getBank(HttpServletRequest request, ResourceClient bloodClient)
    {
        Bloodbanks bank = new Bloodbanks();
        
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
            bank = bloodClient.find_XML(Bloodbanks.class, id);
            
            if(bank == null)
            {
                break;
            }
        }
             
        bank = new Bloodbanks();
        
        bank.setId(id);
        bank.setName(name);
        bank.setAddress(request.getParameter("address"));
        bank.setArea(request.getParameter("area"));
        bank.setCity(request.getParameter("city"));
        bank.setState(request.getParameter("state"));
        bank.setContactDetails(request.getParameter("contactDetails"));
        bank.setIncharge(request.getParameter("incharge"));
        bank.setA1nve(Integer.parseInt(request.getParameter("a1-ve")));
        bank.setA1pve(Integer.parseInt(request.getParameter("a1+ve")));
        bank.setA1Bnve(Integer.parseInt(request.getParameter("a1b-ve")));
        bank.setA1Bpve(Integer.parseInt(request.getParameter("a1b+ve")));
        bank.setA2nve(Integer.parseInt(request.getParameter("a2-ve")));
        bank.setA2pve(Integer.parseInt(request.getParameter("a2+ve")));
        bank.setA2Bnve(Integer.parseInt(request.getParameter("a2b-ve")));
        bank.setA2Bpve(Integer.parseInt(request.getParameter("a2b+ve")));
        bank.setBnve(Integer.parseInt(request.getParameter("b-ve")));
        bank.setBpve(Integer.parseInt(request.getParameter("b+ve")));
        bank.setB1pve(Integer.parseInt(request.getParameter("b1+ve")));
        bank.setOnve(Integer.parseInt(request.getParameter("o-ve")));
        bank.setOpve(Integer.parseInt(request.getParameter("o+ve")));
        
        return bank;
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
        
        Bloodbanks bank = new Bloodbanks();
        
        String message="";
        String id="";
        int count;
        List<Bloodbanks> banks = new ArrayList<>();
        
        //String fromServlet = request.getAttribute("fromServlet")!=null?(String)request.getAttribute("fromServlet"):"";
        String operation = request.getAttribute("operation")!=null?(String)request.getAttribute("operation"):request.getParameter("operation");
        System.out.println("Operation:"+operation);
        id = request.getAttribute("associatedId")==null?"":(String)request.getAttribute("associatedId");
        System.out.println(operation); 
        RequestDispatcher rd = request.getRequestDispatcher("BloodBanks.jsp");
        
        switch(operation)
        {
            case "Create":      request.setAttribute("operation", operation);
                                bank = BloodBankServlet.getBank(request,bloodClient);
                                count = Integer.parseInt(bloodClient.countREST());
                                bloodClient.create_XML(bank);
                                if(count == Integer.parseInt(bloodClient.countREST()))
                                {
                                    message = "Something went wrong, your Record is not inserted!!";
                                }
                                else message = "Record Inserted!!";
                                request.setAttribute("message", message);
                                rd.forward(request, response);
                                break;
            case "RetrieveAll" :    /*GenericType<List<Bloodbanks>> genericType = new GenericType<List<Bloodbanks>>() {};
                                    Response restResponse = bloodClient.findAll_XML(Response.class);
                                    banks = restResponse.readEntity(genericType);
                                    request.setAttribute("banks", banks);*/
                                    break;
            case "Retrieve":    request.setAttribute("operation", operation);
                                String name = request.getParameter("name");
                                String area = request.getParameter("area");
                                id = name.substring(0, 3).toUpperCase();
                                String getId=id;
                                for(int i = 1; i<100 ; i++)
                                {
                                    id = getId;
                                    if(i<10)
                                        id = id+"00"+i;
                                    else if(i>=10 && i<100)
                                        id = id+"0"+i;
                                    bank = bloodClient.find_XML(Bloodbanks.class, id);
                                    if(bank == null)
                                    {
                                        break;
                                    }
                                    else if(bank.getArea().equals(area) && bank.getName().equals(name))
                                    {
                                        break;
                                    }
                                }
                                
                                if(bank == null)
                                {
                                    message = "Record not Found!!";
                                }
                                else 
                                {
                                    message = "Record Found!!";
                                }
                                request.setAttribute("message", message);
                                request.setAttribute("bank", bank);
                                rd.forward(request, response);
                                break;
            case "GetAssociatedWith":    bank = bloodClient.find_XML(Bloodbanks.class, id);
                                         request.setAttribute("bank",bank);
                                         break;
            case "GetUnits":    GenericType<List<Bloodbanks>> genericType = new GenericType<List<Bloodbanks>>() {};
                                Response restResponse = bloodClient.findAll_XML(Response.class);
                                banks = restResponse.readEntity(genericType);
                                System.out.println("banks getUnit");
                                System.out.println("bloodgroup: "+request.getParameter("bloodGroup"));
                                request.setAttribute("banks", banks);
                                request.setAttribute("bloodGroup",request.getParameter("bloodGroup"));
                                request.getRequestDispatcher("index.jsp").forward(request, response);
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
