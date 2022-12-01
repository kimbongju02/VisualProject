using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calendar.NET;

namespace Calendar.NETDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            calendar1.CalendarDate = new DateTime(2012, 5, 2, 0, 0, 0);
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;


            

            /*
            var groundhogEvent = new HolidayEvent
                                     {
                                         Date = new DateTime(2012, 2, 2), // 월, 일
                                         EventText = "Groundhog Day", // 날짜에 추가될 이름
                                         RecurringFrequency = RecurringFrequencies.Yearly //매년 추가
                                     };

            calendar1.AddEvent(groundhogEvent);
            */
            /*
            var exerciseEvent = new CustomEvent
                                    {
                                        Date = DateTime.Now,// 오늘날짜
                                        RecurringFrequency = RecurringFrequencies.EveryMonWedFri,// 매주 월, 수, 금
                                        EventLengthInHours = 1,
                                        EventText = "Time for Exercise!"
                                    };


            calendar1.AddEvent(exerciseEvent);
            */

            /*
            var rehabEvent = new CustomEvent
                {
                    Date = DateTime.Now,
                    RecurringFrequency = RecurringFrequencies.Custom, // 커스텀으로 날짜 설정
                    EventText = "Rehab Therapy",
                    Rank = 3,
                    CustomRecurringFunction = RehabDays
                };

            calendar1.AddEvent(rehabEvent);
            */

            //var ce = new CustomEvent();

            //ce.EventText = "My Event";
            //ce.Date = new DateTime(2012, 4, 1);
            //ce.RecurringFrequency = RecurringFrequencies.Monthly;
            //ce.EventFont = new Font("Verdana", 12, FontStyle.Regular);
            //ce.ThisDayForwardOnly = true;
            //ce.Enabled = true;
            //calendar1.AddEvent(ce);
            
            //var ce2 = new HolidayEvent();

            //ce2.EventText = "test";
            //ce2.Date = new DateTime(2012, 4, 2);
            //ce2.RecurringFrequency = RecurringFrequencies.EveryMonWedFri;
            //ce2.Rank = 3;
            //calendar1.AddEvent(ce2);

            var ce = new CustomEvent();
            ce.IgnoreTimeComponent = false;
            ce.ReadOnlyEvent = false; // 마우스 오른쪽 클릭으로 수정가능
            ce.EventText = "Interview"; // 이름
            ce.Date = new DateTime(2022, 12, 2, 15, 30, 0); // 날짜
            ce.EventLengthInHours = 2f; //진행시간
            ce.RecurringFrequency = RecurringFrequencies.None; // 이벤트가 렌더링되는 빈도
            ce.EventFont = new Font("Verdana", 12, FontStyle.Regular);
            ce.Enabled = true; // 이벤트 활성화 여부
            calendar1.AddEvent(ce);

            var ce2= new CustomEvent();
            ce2.EventText = "add"+"add"; // 이름
            ce2.Date = new DateTime(2022, 12, 3, 15, 30, 0); // 날짜
            ce2.EventFont = new Font("Verdana", 12, FontStyle.Regular);
            ce2.Enabled = true; // 이벤트 활성화 여부
            calendar1.AddEvent(ce2);
        }



        [CustomRecurringFunction("Get Monday and Wednesday", "Selects the Monday and Wednesday of each month")]
        public bool GetMondayAndWednesday(IEvent evnt, DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Monday || dt.DayOfWeek == DayOfWeek.Wednesday)
                return true;
            return false;
        }
    }
}
