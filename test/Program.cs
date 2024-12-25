using System.Threading ;
var thr =new Thread
(
    n =>{
        for(int i=0;i<10;i++){
            Console.WriteLine($"In child thread: {n}") ;
        }
    Thread.Sleep(1000) ;
    Thread.Yield() ;
    }
);
thr.Start(999) ;
for(int i=0;i<10;i++){
    Console.WriteLine($"In main thread: 888") ;
}
thr.Join();
thr.Join(5000) ;