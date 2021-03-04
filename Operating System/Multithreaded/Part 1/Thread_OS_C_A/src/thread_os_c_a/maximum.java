package thread_os_c_a;

import java.util.ArrayList;

public class maximum  {

    private ArrayList<Double> list;
    private double Result;

    public double getResult() {
        return Result;
    }

    public maximum(ArrayList<Double> list) {
        this.list = list;
    }

   
    public  void run() {
        int a = 0;
        double max = list.get(0);
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i)>=max) {
                max = list.get(i);
            }
        }

        Result = max;
//         while(a<200000)
//        {
//            a++;
//                  
//            System.out.println("count "+a);
//        
//        }
    }
}
