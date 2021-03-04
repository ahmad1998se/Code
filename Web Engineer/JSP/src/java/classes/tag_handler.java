/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classes;

import java.io.IOException;
import javax.servlet.jsp.JspException;
import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.PageContext;
import javax.servlet.jsp.tagext.SimpleTagSupport;
import javax.servlet.jsp.tagext.*;
import javax.servlet.jsp.*;
import java.io.*;

public class tag_handler extends SimpleTagSupport {

    String Name;
    double ID;

    public void setName(String Name) {
        this.Name = Name;
    }

    public void setID(double ID) {
        this.ID = ID;
    }

    @Override
    public void doTag() throws JspException, IOException {

        try {
            JspWriter out = getJspContext().getOut();

            out.print("This My Coustom Tag");
            out.println("<p>The Name Of Student Is :" + Name + " The ID is : " + ID + "</p>");
            super.doTag();

        } catch (Exception e) {
            e.printStackTrace();
        }
//To change body of generated methods, choose Tools | Templates.
    }

}
