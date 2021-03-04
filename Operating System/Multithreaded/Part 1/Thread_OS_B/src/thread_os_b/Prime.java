/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_b;

import java.util.ArrayList;


public class Prime extends Thread{
    
    @Override
    public  void run() {
        
        for (int i = 0; i <= Thread_OS_B.size; i++) 
        {
            if (!(i%2==0)) 
            {
                System.out.println("Prime Number "+i);   
            }
        }

        
    }
}
