using System;
using System.Collections;
using System.Collections.Generic;

namespace proots{
    public class proots{
        public struct message{
            public String mess;
            public List<int> list;

            public String ReadMess(){
                //message構造体のmessを返す関数
                //引数:なし
                //返り値:mess
                return(this.mess);
            }
            public List<int> ReadList(){
                //message構造体のlistを返す関数
                //引数:なし
                //返り値:list
                return(this.list);
            }
        }
        public static void Main(){
            int num;
            var sw = new System.Diagnostics.Stopwatch();
            List<int> roots=new List<int>();
            while(true){
                try{
                    System.Console.Write("input 'num':");
                    num = int.Parse(System.Console.ReadLine());
                    if(num>2&&proots.prime(num)) break;
                    System.Console.WriteLine("'not prime' or 'num <= 2'");
                }catch(System.FormatException){
                    System.Console.WriteLine("error");
                }
            }
            
            System.Console.WriteLine("{0} is PrimeNumber",num);
            sw.Start();
            roots=proots.roots_v3(num);
            sw.Stop();
            System.Console.WriteLine("roots_v3");
            System.Console.Write("\troots({0}):",num);
            proots.ListWriteLine_int(roots);
            System.Console.WriteLine("\trun time:{0}(ms)",sw.ElapsedMilliseconds);

            sw.Restart();
            roots=proots.roots_v2(num);
            sw.Stop();
            System.Console.WriteLine("roots_v2");
            System.Console.Write("\troots({0}):",num);
            proots.ListWriteLine_int(roots);
            System.Console.WriteLine("\trun time:{0}(ms)",sw.ElapsedMilliseconds);

            sw.Restart();
            roots=proots.roots(num);
            sw.Stop();
            System.Console.WriteLine("roots");
            System.Console.Write("\troots({0}):",num);
            proots.ListWriteLine_int(roots);
            System.Console.WriteLine("\trun time:{0}(ms)",sw.ElapsedMilliseconds);

        }
        
        private static void ListWriteLine_int(List<int> list){
            System.Console.Write("[");
            foreach(int i in list){
                System.Console.Write("{0},",i);
            }
            System.Console.WriteLine("]");
        }

        private static void ArrayWriteLine_int(int[] Array){
            System.Console.Write("[");
            foreach(int i in Array){
                System.Console.Write("{0},",i);
            }
            System.Console.WriteLine("]");
        }

        private static List<int> roots(int num){
            List<int> roots=new List<int>();
            int numt=num-1;

            for(int i=0;i<numt;i++){
                int[] test = new int[numt];
                int it=i+1;
                for(int n=0;n<numt;n++){
                    int nt=n+1;
                    //System.Console.WriteLine("i:{0},n:{1},num:{2}--{3},{4}",it,nt,num,(ulong)Math.Pow(it,nt),(ulong)Math.Pow(it,nt)%(ulong)num);
                    int m=(int)((ulong)Math.Pow(it,nt) % (ulong)num);
                    if(m==0) return(roots);
                    test[n]=m;
                }
                //proots.ArrayWriteLine_int(test);
                if(dup(test))    roots.Add(it);
            }
            return(roots);
        }

        private static message roots_ob(int num){
            List<int> roots=new List<int>();
            message mess = new message();
            int numt=num-1;

            for(int i=0;i<numt;i++){
                int[] test = new int[numt];
                int it=i+1;
                for(int n=0;n<numt;n++){
                    int nt=n+1;
                    System.Console.WriteLine("i:{0},n:{1},num:{2}--{3},{4}",it,nt,num,(ulong)Math.Pow(it,nt),(ulong)Math.Pow(it,nt)%(ulong)num);
                    int m=(int)((ulong)Math.Pow(it,nt) % (ulong)num);
                    if(m==0){
                        mess.mess="Failed";
                        mess.list=roots;
                        return(mess);
                    }
                    test[n]=m;
                }
                proots.ArrayWriteLine_int(test);
                if(dup(test))    roots.Add(it);
            }
            mess.mess="Success";
            mess.list=roots;
            return(mess);
        }
        
        private static List<int> roots_v2(int num){
            List<int> roots=new List<int>();
            int numt=num-1;

            for(int i=0;i<numt-1;i++){
                int[] test = new int[numt];
                int it=i+2;
                for(int n=0;n<numt;n++){
                    int nt=n+1;
                    //System.Console.Write("call from roots_ob_v2,");
                    int m = roots_math(it,nt,num,0);
                    //System.Console.WriteLine("i:{0},n:{1},num:{2}--{3},{4}",it,nt,num,(ulong)Math.Pow(it,nt),(ulong)Math.Pow(it,nt)%(ulong)num);
                    test[n]=m;
                }
                //proots.ArrayWriteLine_int(test);
                if(dup(test))    roots.Add(it);
            }
            return(roots);
        }

        private static List<int> roots_v3(int num){
            List<int> roots=new List<int>();
            int numt=num-1;

            for(int i=0;i<numt-1;i++){
                int[] test = new int[numt];
                int it=i+2;
                bool flag=true;
                for(int n=0;n<numt;n++){
                    int nt=n+1;
                    //System.Console.Write("call from roots_ob_v2,");
                    int m = roots_math(it,nt,num,0);
                    //System.Console.WriteLine("i:{0},n:{1},num:{2}--{3},{4}",it,nt,num,(ulong)Math.Pow(it,nt),(ulong)Math.Pow(it,nt)%(ulong)num);
                    if(!dup_in_array(test,m)){
                        flag=false;
                        break;
                    }
                    test[n]=m;
                }
                //ArrayWriteLine_int(test);
                //proots.ArrayWriteLine_int(test);
                if(flag)    roots.Add(it);
            }
            return(roots);
        }

        public static int roots_math(int i,int n,int num,int ind){
            //ind=ind+1;
            //System.Console.WriteLine("to roots_math");
            
            //proots.Indent(ind);
            //System.Console.WriteLine("i:{0},n:{1},num:{2}",i,n,num);
            
            double log2 = Math.Log(i,2);
            int m;

            //proots.Indent(ind);
            //System.Console.WriteLine("n:{0},log2:{1},n*log2:{2}",n,log2,n*log2);
            
            //proots.Indent(ind);
            //System.Console.WriteLine("\tMath.Ceiling(n*log2)>=53:{0}",Math.Ceiling(n*log2)>=53);

            if(Math.Ceiling(n*log2)>=53){
                double n2 = (double)n/2;
                //proots.Indent(ind);
                //System.Console.WriteLine("n:{0},Ceiling(n/2):{1},Floor(n/2):{2}",n,Math.Ceiling(n2),Math.Floor(n2));
                
                //proots.Indent(ind);
                //System.Console.Write("call from roots_math,");
                int it=roots_math(i,(int)Math.Ceiling(n2),num,ind+1);
                
                //proots.Indent(ind);
                //System.Console.Write("call from roots_math,");
                int nt=roots_math(i,(int)Math.Floor(n2),num,ind+1);
                
                m=(it*nt)%num;
                //proots.Indent(ind);
                //System.Console.WriteLine("it:{0},nt:{1},it*nt:{2}",it,nt,it*nt);
            }else{
                m=(int)((ulong)Math.Pow(i,n) % (ulong)num);
            }
            //proots.Indent(ind);
            //System.Console.WriteLine("m:{0}",m);
            return(m);
        }

        private static bool prime(int num){
            for(int i=2;i<num;i++)  if(num%i==0)    return(false);
            return(true);
        }

        private static bool dup(int[] test){
            HashSet<int> set=new HashSet<int>();
            foreach(int DupList in test){
                if(DupList == 0) continue;
                if(!set.Add(DupList))   return(false);
            }
            return(true);
        }

        private static bool dup_in_array(int[] test,int num){
            HashSet<int> set=new HashSet<int>();
            foreach(int DupList in test){
                if(DupList == 0) break;
                if(!set.Add(DupList))   return(false);
            }
            if(!set.Add(num))   return(false);
            return(true);
        }

        private static void Indent(int ind){
            for(int i=0;i<=ind;i++){
                System.Console.Write("\t");
            }
        }
    }
}