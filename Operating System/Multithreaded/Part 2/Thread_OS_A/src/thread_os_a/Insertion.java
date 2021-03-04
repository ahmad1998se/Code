/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_a;

import java.util.ArrayList;

/**
 *
 * @author Ahmad
 */
public class Insertion extends Thread {

    private int list[] = new int[25];

    public Insertion() {
        int c = 0;
        for (int i = 50; i <= 74; i++) {
            list[c] = Thread_OS_A.Glist[i];
            c++;
        }
    }

    public int[] getarray() {
        return list;
    }

    @Override
    public void run() {

        for (int i = 1; i < list.length; i++) {
            int current = list[i];
            int j = i - 1;
            while (j >= 0 && current < list[j]) {
                list[j + 1] = list[j];
                j--;
            }
            // at this point we've exited, so j is either -1
            // or it's at the first element where current >= a[j]
            list[j + 1] = current;
        }

    }
}
