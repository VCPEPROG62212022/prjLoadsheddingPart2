using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLoadsheddingPart2
{
    class Area <T>
    {
        private object[] AreaName;
        private object[] arrStage1;
        private object[] arrStage2;
        private object[] arrStage3;
        private object[] arrStage4;
        private object[] Day;
        private int iCount = 0;// running total
        private int iSize;// size of the area that was set


        public string areaSelcted = "";
        public string stage = "";
        public Area(int iSize)
        {
            this.iSize = iSize;
            arrStage1 = new object[iSize];
            arrStage2 = new object[iSize];
            arrStage3 = new object[iSize];
            arrStage4 = new object[iSize];
            Day = new object[iSize];
            AreaName = new object[iSize];
        }

        public void Push(object stage1, object stage2,
            object stage3, object stage4 ,object day,object Name)
        {
            arrStage1[iCount] = stage1;
            arrStage2[iCount] = stage2;
            arrStage3[iCount] = stage3;
            arrStage4[iCount] = stage4;
            Day[iCount] = day;
            AreaName[iCount] = Name;
            iCount++;
        }


        public object[] getUniqueAreas()
        {// https://www.csharp-code.com/2013/09/c-example-array-distinct.html
            object[] distinctArrays = AreaName.Distinct().ToArray();
            return distinctArrays;
        }
        public object[] getUniqueDays()
        {//https://www.csharp-code.com/2013/09/c-example-array-distinct.html
            object[] distinctArrays = Day.Distinct().ToArray();
            return distinctArrays;
        }

        
        public object getData()
        {
            string strOutput ="";
               if (areaSelcted.Length>0 && stage.Length>0)
                {
                    for (int i = 0;i<iCount;i++)
                    {
                        if (AreaName[i].Equals(areaSelcted))
                        {
                        strOutput += "Day :" + Day[i] + " Loadshedding at :";
                        if (stage.Equals("1"))
                         {
                           strOutput += arrStage1[i];
                         }else if (stage.Equals("2"))
                          {
                            strOutput += arrStage2[i];
                        }
                        else  if (stage.Equals("3"))
                        {
                            strOutput += arrStage3[i];
                        }else if (stage.Equals("4"))
                        {
                            strOutput += arrStage4[i];
                        }
                        strOutput += "\n";
                    }
                    

                    }
                }

            return strOutput;
        }
    }
}
