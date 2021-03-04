package thread_os_a;

import java.util.ArrayList;

public class Thread_OS_A {

    public static ArrayList<Double> list = new ArrayList<Double>();
    public static double avg;
    public static double min;
    public static double max;

    public static void main(String[] args) throws InterruptedException {
        final long startTime = System.currentTimeMillis();
        final long elapsedTimeMillis;
        ArrayList<Double> list = new ArrayList<Double>();

        list.add(35.6);
        list.add(100.6);
        list.add(200.6);

        average first = new average(list);
        maximum second = new maximum(list);
        minimum third = new minimum(list);

        first.start();
        second.start();
        third.start();

        while (true) {  
            if (!first.isAlive() && !second.isAlive() && !third.isAlive()) {
                System.out.println(" The average value is " + avg);
                System.out.println(" The maximum value is " + max);
                System.out.println(" The minimum value is " + min);              
                break;
            }
        }
        elapsedTimeMillis = System.currentTimeMillis() - startTime;
        System.out.println("Time To Finish =" + elapsedTimeMillis);

    }
}
