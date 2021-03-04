/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_c_b;

import java.util.ArrayList;


public class Prime {
    
    
    public  void run() {
        
        for (int i = 0; i <= Thread_OS_C_B.size; i++) 
        {
            if (!(i%2==0)) 
            {
                System.out.println("Prime Number "+i);   
            }
        }

        
    }
}
