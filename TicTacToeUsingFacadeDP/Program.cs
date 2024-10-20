using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeUsingFacadeDP.Presentation;

namespace TicTacToeUsingFacadeDP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameUI.PlayGame();

            /* Hello In Application I have Demonstrated Facade Design Pattern By Implementing Tic-Tac-Toe Game... 
             
               1. Facade Design Pattern is Used To Hide Internal Complexities of Sub-Systems and Shows the Simplified
               and Unified Interface to User.
               
               2. Here in this Game I have Implemented Simple Facade DP but as compared to this it is more useful in 
                  Complex Scenario. for example. Video Streaming Platforms, Banking Systems, E-commerce.

               3. Facade is useful to Reduce Dependency...User Dont Need to know Actual Implementation Details of
                  Subsystem.
               
               4. Facade Help in Code Organization...Facade organizes code by creating a single entry point for multiple 
                  systems, making it easier to maintain and understand.
              
               5. The other Side of Facade DP : I. It Reduces Flexibility II. Hard To Maintain III. Lead to SRP violation
               
               6. Use Cases :
                  I. Useful When You Want To Simplify Interactions With A Complex System And Keep The Client Code Clean 
                     And Easy To Maintain.
                 II. Not Ideal For Cases Where Full Control Or Access To The Subsystems Is Required, Or When The System
                     Is Already Simple.
               
               ** NOTE : FACADE DESIGN PATTERN IS IMPLEMENTED IN ResultAnalyzer Class... Thank You! **
             */

        }
    }
}
