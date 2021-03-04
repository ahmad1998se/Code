package thread_os_a;

import java.util.ArrayList;
import java.util.Random;

public class Thread_OS_A {

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
        a1.start();
        a2.start();
        a3.start();
        a4.start();

        while (true) {
            if (!a1.isAlive() && !a2.isAlive() && !a3.isAlive() && !a4.isAlive()) {
                a5 = new Merge(a1.getarray(), a2.getarray(), a3.getarray(), a4.getarray());
                a5.start();
                break;
            }
        }
        System.out.println("First 25 index Bubble second 25 index BuildIn Third 25 index Insertion fourth 25 index Selection");
        while (true) {
            if (!a5.isAlive()) {
                for (int i = 0; i < a5.getarray().length; i++) {
                    System.out.println("Length " + i + " Value " + a5.getarray()[i]);
                }
                break;
            }
        }
        elapsedTimeMillis = System.currentTimeMillis() - startTime;
         System.out.println("Time To Finish " + elapsedTimeMillis);

    }

}
