package thread_os_a;

import java.util.ArrayList;

public class minimum extends Thread {

    private ArrayList<Double> list;

    public minimum(ArrayList<Double> list) {
        this.list = list;
    }

    @Override
    public void run() {

        double min = list.get(0);
        //int a=0;
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i) <= min) {
                min = list.get(i);
            }
        }
        Thread_OS_A.min = min;
//         while(a<100)
//        {           
//            a++;                 
//            System.out.println("I'm Thread Min Count"+a);        
//        }

    }

}
