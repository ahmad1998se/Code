package thread_os_a;

import java.util.ArrayList;

public class average extends Thread {

    private ArrayList<Double> list;

    public average(ArrayList<Double> list) {
        this.list = list;
    }

    @Override
    public void run() {

        double sum = 0;
        //  int a=0;
        for (int i = 0; i < list.size(); i++) {
            sum += list.get(i);
        }

        Thread_OS_A.avg = sum / list.size();
//        while(a<100)
//        {         
//            a++;                 
//            System.out.println("I'm Thread Avg Count"+a);
//        
//        }
// 

    }

}
