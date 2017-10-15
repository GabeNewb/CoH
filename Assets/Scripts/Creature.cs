using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Creature {

	public int experience {get; set;}
	public int level {get; set;}
	public string name {get; set;}

	public Creature(int experience, int level, string name) {
		this.experience = experience;
		this.level = level;
		this.name = name;
	}

	public nameAndLevel() {
		return String.Format("{0} lv. {1}",name,level);
	}

	public initializeCreature(creatureName) {
		experience = 0;
		level = 0;
		name = creatureName;
	}

	public checkLevel(experience, level) {
		if (level == 1) {
			if (exp > 5) {
				this.gainLevel();
			}
		}
		else if (level == 2) {
			if (exp > 25) {
				this.gainLevel();
			}
		}
		else if (level == 3) {
			if (exp > 75) {
				this.gainLevel();
			}
		}
		else if (level == 4) {
			if (exp > 175) {
				this.gainLevel();
			}
		}
		else if (level == 5) {
			if (exp > 300) {
				this.gainLevel();
			}
		}
	}

	public gainLevel(level) {
		level++;
	}

	public gainExp(expGain) {
		experience = experience + expGain;
	}
}
