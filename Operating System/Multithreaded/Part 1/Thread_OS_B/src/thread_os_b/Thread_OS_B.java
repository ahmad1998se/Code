/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_b;

import java.util.Scanner;

/**
 *
 * @author Ahmad
 */
public class Thread_OS_B {

    public static int size;

    public static void main(String[] args) throws InterruptedException {
        System.out.println(" Plsease Enter Int or Number To Calculate Prime ");
        Scanner in = new Scanner(System.in);
        size = in.nextInt();
        final long startTime = System.currentTimeMillis();
        final long elapsedTimeMillis;
        Prime p = new Prime();
        p.start();        

        while (true) {
            if (p.isAlive() == false) {
                System.out.println("Im Finish Working...");
                 elapsedTimeMillis = System.currentTimeMillis() - startTime;
                 System.out.println("Time To Finish =" + elapsedTimeMillis);
                break;
            }
        }
       
    }

}