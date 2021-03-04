/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_c_a;

import java.util.ArrayList;

/**
 *
 * @author Ahmad
 */
public class Thread_OS_C_A {

    public static ArrayList<Double> list = new ArrayList<Double>();

    public static void main(String[] args) {
        ArrayList<Double> list = new ArrayList<Double>();
        final long startTime = System.currentTimeMillis();
        final long elapsedTimeMillis;

        list.add(35.6);
        list.add(100.6);
        list.add(200.6);
        average first = new average(list);
        maximum second = new maximum(list);
        minimum third = new minimum(list);
        first.run();
        second.run();
        third.run();
        System.out.println("The average value is " + first.getResult());
        System.out.println("The maximum value is " + second.getResult());
        System.out.println("The minimum value is " + third.getResult());       
        elapsedTimeMillis = System.currentTimeMillis() - startTime;
        System.out.println("Time To Finish =" + elapsedTimeMillis);

    }

}
