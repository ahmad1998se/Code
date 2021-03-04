/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package just.se;

import javax.servlet.jsp.JspException;
import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.tagext.TagSupport;

/**
 *
 * @author Dr. Zakarea AL SHARA <zmalshara@just.edu.o>
 */
public class Student extends TagSupport{
    private int sid;
    private String name;
    
    @Override
    public int doStartTag() throws JspException{
        JspWriter out = pageContext.getOut();
        try{
            out.print("<h2>");
            out.println("Student name: " + name);
            out.print("<br>");
            out.println("Student ID: " + sid);
            out.print("</h2>");
            
        }catch(Exception e){
            e.printStackTrace();
        }
        return SKIP_BODY; 
    }

    public void setSid(int sid) {
        this.sid = sid;
    }

    public int getSid() {
        return sid;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
    
    
    
}
