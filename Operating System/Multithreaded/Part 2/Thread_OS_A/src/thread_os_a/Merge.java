/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thread_os_a;

import java.util.ArrayList;
import java.util.Arrays;

public class Merge extends Thread {

    private int list[] = new int[Thread_OS_A.Glist.length];
    private int Bubble[] = new int[25];
    private int BuildIn[] = new int[25];
    private int Insertion[] = new int[25];
    private int Selection[] = new int[25];

    public Merge(int list1[], int list2[], int list3[], int list4[]) {
        this.Bubble = list1;
        this.BuildIn = list2;
        this.Insertion = list3;
        this.Selection = list4;
    }

    public int[] getarray() {
        return list;
    }

    @Override
    public void run() {

//        for (int i = 0; i <= 24; i++) {
//            list[i]=Bubble[i];
//            
//        }
//        for (int i = 25; i <= 49; i++) {
//                        list[i]=BuildIn[i-25];
//        }
//        for (int i = 50; i <= 74; i++) {
//                        list[i]=Insertion[i-50];
//        }
//          for (int i = 75; i <= 99; i++) {
//                        list[i]=Selection[i-75];
//        }
        for (int i = 0; i < list.length; i++) {
            if (i <= 24) {
                list[i] = Bubble[i];
            } else if (i >= 25 && i <= 49) {
                list[i] = BuildIn[i - 25];
            } else if (i >= 50 && i <= 74) {
                list[i] = Insertion[i - 50];
            } else if (i >= 75 && i <= 99) {
                list[i] = Selection[i - 75];
            }

        }

    }
}
