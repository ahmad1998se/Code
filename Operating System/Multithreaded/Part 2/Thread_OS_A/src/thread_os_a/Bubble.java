/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_a;

/**
 *
 * @author Ahmad
 */
public class Bubble extends Thread {

    private int list[] = new int[25];

    public Bubble() {
        int c = 0;
        for (int i = 0; i <= 24; i++) {
            list[c] = Thread_OS_A.Glist[i];
            c++;
        }
    }

    public int[] getarray() {
        return list;
    }

    @Override
    public void run() {

        boolean sorted = false;
        int temp;
        while (!sorted) {
            sorted = true;
            for (int i = 0; i < list.length - 1; i++) {
                if (list[i] > list[i + 1]) {
                    temp = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = temp;
                    sorted = false;
                }
            }
        }

    }

}
