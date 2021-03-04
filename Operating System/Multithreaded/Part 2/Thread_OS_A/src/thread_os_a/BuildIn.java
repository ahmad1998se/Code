/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_a;

import java.util.Arrays;

/**
 *
 * @author Ahmad
 */
public class BuildIn extends Thread {

    private int list[] = new int[25];

    public BuildIn() {
        int c = 0;
        for (int i = 25; i <= 49; i++) {
            list[c] = Thread_OS_A.Glist[i];
            c++;
        }
    }

    public int[] getarray() {
        return list;
    }

    @Override
    public void run() {

        Arrays.sort(list);

    }

}
