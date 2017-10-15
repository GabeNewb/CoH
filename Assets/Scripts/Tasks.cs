using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public enum DayOfTheWeek {
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}

class Task {
	public string title { get; set; }
	public double time { get; set; }
	public int weekLength { get; set; }
	public enum daysOfTheWeek[] { get; set; }
	public bool active { get; set; }

	public Task(string titleChosen, double timeChosen, int weeksChosen, array chosenDays) {
		this.title = titleChosen;
		this.time = timeChosen;
		this.weekLength = weeksChosen;
		this.daysOfTheWeek[] = chosenDays;
		this.active = false;
	}

	public TimeToDoTheThing(enum[] daysOfTheWeek) {
		DateTime rightNow = DateTime.now;
		int hour = rightNow.hour;
		int minute = rightNow.minute;
		double timeAdjusted;
		if (time%1 == 0) {
			timeAdjusted = time - .7;
		}
		else {
			timeAdjusted = time - .3;
		}

		if (daysOfTheWeek.contains(rightNow.DayOfWeek) && (timeAdjusted == (hour + "." + minute) ) {
			setTaskActive(true);
		}
		if (daysOfTheWeek.contains(rightNow.DayOfWeek) && (time - timeAdjusted == 1)) {
			setTaskActive(false);
		}

	}

	public setTaskActive(bool active) {
		active.set(active);
	}
}