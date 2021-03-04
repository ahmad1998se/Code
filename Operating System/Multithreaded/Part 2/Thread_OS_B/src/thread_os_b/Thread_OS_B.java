/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_b;

import java.util.Random;

/**
 *
 * @author Ahmad
 */
public class Thread_OS_B {

    public static int Glist[] = new int[100];

    public static void main(String[] args) {
        final long startTime = System.currentTimeMillis();
        final long elapsedTimeMillis;
        Random r = new Random();
        for (int i = 0; i < 100; i++) {
            Glist[i] = r.nextInt(100 - 1) + 1;
        }

        Bubble a1 = new Bubble();
        BuildIn a2 = new BuildIn();
        Insertion a3 = new Insertion();
        Selection a4 = new Selection();
        Merge a5;
        a1.run();
        a2.run();
        a3.run();
        a4.run();

        a5 = new Merge(a1.getarray(), a2.getarray(), a3.getarray(), a4.getarray());
        a5.run();

        System.out.println("First 25 index Bubble second 25 index BuildIn Third 25 index Insertion fourth 25 index Selection");

        for (int i = 0; i < a5.getarray().length; i++) {
            System.out.println("Length " + i + " Value " + a5.getarray()[i]);

        }
        elapsedTimeMillis = System.currentTimeMillis() - startTime;
        System.out.println("Time To Finish " + elapsedTimeMillis);
    }

}
