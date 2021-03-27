# Live Project

## Introduction

For the last two weeks at The Tech Academy, I worked with my fellow students in a team developing a .NET Core MVC website ultilizing Entity Framework. Our team used Azure Devops to organize the project, which I found to work well for staying organized and sending/ receiving feedback on individual stories. We started with a basic existing website and added many new requested features and troubleshooting any bugs in both the front and back ends.

Below are some descriptions and code snippets to highlight some of my work.

## Back End Stories


```c#
public class CalendarEvent
	{
		[Key]
		public int EventId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		[DataType(DataType.Date)] // These annotations set the time and date formats
		[DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",  ApplyFormatInEditMode = true)]
		public DateTime? StartDate { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? EndDate { get; set; }
		[DataType(DataType.Time)]
		[DisplayFormat(DataFormatString = "{0:h:mm tt}", ApplyFormatInEditMode = true)]
		public DateTime? StartTime { get; set; }
		[DataType(DataType.Time)]
		[DisplayFormat(DataFormatString = "{0:h:mm tt}", ApplyFormatInEditMode = true)]
		public DateTime? EndTime { get; set; }
		public bool IsProduction { get; set; }
		public int? ProductionId { get; set; }
	}
```
![event screenshot 1](/c--course-work\csharpliveproject\event1.PNG)

```c#
@if (item.StartTime == null)
{
    <p>All Day <i class="fas fa-clock"></i></p>
}
else
{
    <p>@((item.EndDate - item.StartDate).Value.Days) Days <i class="fas fa-clock"></i></p>
```

```c#
@if (item.EndDate == DateTime.Now.Date)
{
    <p class="prod-calendar--lastday">Last Day!</p>
}
else if (item.StartDate > DateTime.Now)
{
    <p></p>
}
else
{
    <p class="prod-calendar--daysleft">@((item.EndDate - DateTime.Now).Value.Days) days remaining!</p>
}
```

```c#
@if (item.StartTime == null)
{
    @* display span of days *@
    <text>
        @Html.DisplayFor(modelItem => item.StartDate.Value.DayOfWeek) - @Html.DisplayFor(modelItem => item.EndDate.Value.DayOfWeek)
    </text>
}
else
{
    @* display span of days and times *@
    <text>
        @Html.DisplayFor(modelItem => item.StartDate.Value.DayOfWeek) - @Html.DisplayFor(modelItem => item.EndDate.Value.DayOfWeek), @Html.DisplayFor(modelItem => item.StartTime) - @Html.DisplayFor(modelItem => item.EndTime)
    </text>
}
```
## Front End Stories

