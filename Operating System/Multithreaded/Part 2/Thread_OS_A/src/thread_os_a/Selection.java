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
public class Selection extends Thread {

    private int list[] = new int[25];

    public Selection() {
        int c = 0;
        for (int i = 75; i <= 99; i++) {
            list[c] = Thread_OS_A.Glist[i];
            c++;
        }
    }

    public int[] getarray() {
        return list;
    }

    @Override
    public void run() {

        for (int i = 0; i < list.length; i++) {
            int min = list[i];
            int minId = i;
            for (int j = i + 1; j < list.length; j++) {
                if (list[j] < min) {
                    min = list[j];
                    minId = j;
                }
            }
            // swapping
            int temp = list[i];
            list[i] = min;
            list[minId] = temp;
        }
    }
}
