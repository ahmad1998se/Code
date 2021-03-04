package thread_os_a;

import java.util.ArrayList;

public class maximum extends Thread {

    private ArrayList<Double> list;

    public maximum(ArrayList<Double> list) {
        this.list = list;
    }

    @Override
    public void run() {

        double max = list.get(0);
        //int a=0;
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i) >= max) {
                max = list.get(i);
            }
        }

        Thread_OS_A.max = max;
//         while(a<100)
//        {
//            
//            a++;
//                  
//            System.out.println("I'm Thread Max Count "+a);
//        
//        }

    }

}
