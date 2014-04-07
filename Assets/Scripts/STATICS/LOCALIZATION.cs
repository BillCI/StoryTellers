using UnityEngine;
using System.Collections;

public static class LOCALIZATION {
	public enum language {english}

	private static LOCALIZATION.language _currentLanguage = LOCALIZATION.language.english;
	public static LOCALIZATION.language currentLanguage {
		get {
			return LOCALIZATION._currentLanguage;
		}
		set {
			//TODO: implemnt some sort of language seltion;
		}
	}

	public static string Fear{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Fear";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Anger{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Anger";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Disgust{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Disgust";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Sad{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Sad";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Happy{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Happy";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Surprise{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Surprise";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Scared{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Scared";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Anxious{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Anxious";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Insecure{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Insecure";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Submissive{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Submissive";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Rejected{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Rejected";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Humiliated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Humiliated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Hurt{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Hurt";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Threatened{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Threatened";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Hateful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Hateful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Mad{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Mad";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Aggressive{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Aggressive";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Frustrated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Frustrated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Distant{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Distant";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Critical{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Critical";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Disapproval{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Disapproval";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Disappointed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Disappointed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Awful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Awful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Avoidance{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Avoidance";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Guilty{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Guilty";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Abandoned{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Abandoned";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Despair{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Despair";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Depressed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Depressed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Lonely{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Lonely";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Bored{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Bored";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Optimistic{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Optimistic";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Intimate{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Intimate";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Peaceful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Peaceful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Powerful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Powerful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Accepted{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Accepted";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Proud{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Proud";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Interested{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Interested";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Joyful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Joyful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Excited{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Excited";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Amazed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Amazed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Confused{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Confused";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Startled{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Startled";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Frightened{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Frightened";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Overwhelmed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Overwhelmed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Worried{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Worried";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Inadequate{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Inadequate";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Inferior{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Inferior";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Worthless{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Worthless";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Insignificant{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Insignificant";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Inadequate{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Inadequate";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Alienated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Alienated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Disrespected{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Disrespected";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Ridiculed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Ridiculed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Emarrassed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Emarrassed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Devastated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Devastated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Insecure{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Insecure";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Jealous{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Jealous";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Resentful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Resentful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Violated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Violated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Furious{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Furious";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Enraged{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Enraged";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Provoked{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Provoked";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Hostile{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Hostile";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Infuriated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Infuriated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Withdrawn{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Withdrawn";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Suspicious{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Suspicious";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Skeptical{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Skeptical";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Sarcastic{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Sarcastic";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Judgmental{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Judgmental";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Loathing{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Loathing";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Repugnant{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Repugnant";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Revolted{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Revolted";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Revulsion{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Revulsion";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Detestable{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Detestable";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Aversion{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Aversion";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Hesitant{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Hesitant";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Remorseful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Remorseful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Ashamed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Ashamed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Ignored{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Ignored";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Victimized{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Victimized";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Powerless{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Powerless";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Vulnerable{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Vulnerable";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Inferior{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Inferior";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Empty{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Empty";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Abandoned{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Abandoned";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Isolated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Isolated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Apathetic{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Apathetic";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Indifferent{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Indifferent";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Inspired{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Inspired";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Open{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Open";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Playful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Playful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Sensitive{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Sensitive";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Hopeful{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Hopeful";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Loving{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Loving";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Provocative{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Provocative";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Courageous{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Courageous";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Fulfilled{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Fulfilled";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Respected{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Respected";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Confident{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Confident";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Important{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Important";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Inquisitive{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Inquisitive";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Amused{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Amused";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Ecstatic{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Ecstatic";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Liberated{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Liberated";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Energetic{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Energetic";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Eager{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Eager";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Awe{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Awe";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Astonished{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Astonished";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Perplexed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Perplexed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Disillusioned{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Disillusioned";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Dismayed{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Dismayed";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Shocked{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Shocked";
			} else {
				return "Error: 601";
			}
		} set {} 
	}
	public static string Terrified{
		get {
			if(LOCALIZATION.currentLanguage == LOCALIZATION.language.english){
				return "Terrified";
			} else {
				return "Error: 601";
			}
		} set {} 
	}


}
