using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EmotionWheal : MonoBehaviour {
	private Dictionary<string,Emotion> _emotions{
		get {
			if(this._emotions == null){
				this._emotions = EmotionWheal.getDefaultWheal();
			}
			return this._emotions;
		}
		set {
			this._emotions = value;
		}
	}
	public Emotion fear{
		get{ return this._emotions["fear"];}
		set{}
	}
	public Emotion scared{
		get{ return this._emotions["scared"];}
		set{}
	}
	public Emotion terrified{
		get{ return this._emotions["terrified"];}
		set{}
	}
	public Emotion frightened{
		get{ return this._emotions["frightened"];}
		set{}
	}
	public Emotion anxious{
		get{ return this._emotions["anxious"];}
		set{}
	}
	public Emotion overwhelmed{
		get{ return this._emotions["overwhelmed"];}
		set{}
	}
	public Emotion worried{
		get{ return this._emotions["worried"];}
		set{}
	}
	public Emotion apprehensive{
		get{ return this._emotions["apprehensive"];}
		set{}
	}
	public Emotion inadequate{
		get{ return this._emotions["inadequate"];}
		set{}
	}
	public Emotion inferior{
		get{ return this._emotions["inferior"];}
		set{}
	}
	public Emotion submissive{
		get{ return this._emotions["submissive"];}
		set{}
	}
	public Emotion worthless{
		get{ return this._emotions["worthless"];}
		set{}
	}
	public Emotion insignificant{
		get{ return this._emotions["insignificant"];}
		set{}
	}
	public Emotion rejected{
		get{ return this._emotions["rejected"];}
		set{}
	}
	public Emotion deficient{
		get{ return this._emotions["deficient"];}
		set{}
	}
	public Emotion alienated{
		get{ return this._emotions["alienated"];}
		set{}
	}
	public Emotion humiliated{
		get{ return this._emotions["humiliated"];}
		set{}
	}
	public Emotion disrespected{
		get{ return this._emotions["disrespected"];}
		set{}
	}
	public Emotion ridiculed{
		get{ return this._emotions["ridiculed"];}
		set{}
	}
	public Emotion anger{
		get{ return this._emotions["anger"];}
		set{}
	}
	public Emotion hurt{
		get{ return this._emotions["hurt"];}
		set{}
	}
	public Emotion embarrassed{
		get{ return this._emotions["embarrassed"];}
		set{}
	}
	public Emotion devastated{
		get{ return this._emotions["devastated"];}
		set{}
	}
	public Emotion threatened{
		get{ return this._emotions["threatened"];}
		set{}
	}
	public Emotion insecure{
		get{ return this._emotions["insecure"];}
		set{}
	}
	public Emotion jealous{
		get{ return this._emotions["jealous"];}
		set{}
	}
	public Emotion hateful{
		get{ return this._emotions["hateful"];}
		set{}
	}
	public Emotion resentful{
		get{ return this._emotions["resentful"];}
		set{}
	}
	public Emotion violated{
		get{ return this._emotions["violated"];}
		set{}
	}
	public Emotion mad{
		get{ return this._emotions["mad"];}
		set{}
	}
	public Emotion furious{
		get{ return this._emotions["furious"];}
		set{}
	}
	public Emotion enraged{
		get{ return this._emotions["enraged"];}
		set{}
	}
	public Emotion aggressive{
		get{ return this._emotions["aggressive"];}
		set{}
	}
	public Emotion provoked{
		get{ return this._emotions["provoked"];}
		set{}
	}
	public Emotion hostile{
		get{ return this._emotions["hostile"];}
		set{}
	}
	public Emotion frustrated{
		get{ return this._emotions["frustrated"];}
		set{}
	}
	public Emotion infuriated{
		get{ return this._emotions["infuriated"];}
		set{}
	}
	public Emotion irritated{
		get{ return this._emotions["irritated"];}
		set{}
	}
	public Emotion distant{
		get{ return this._emotions["distant"];}
		set{}
	}
	public Emotion withdrawn{
		get{ return this._emotions["withdrawn"];}
		set{}
	}
	public Emotion suspicious{
		get{ return this._emotions["suspicious"];}
		set{}
	}
	public Emotion critical{
		get{ return this._emotions["critical"];}
		set{}
	}
	public Emotion skeptical{
		get{ return this._emotions["skeptical"];}
		set{}
	}
	public Emotion sarcastic{
		get{ return this._emotions["sarcastic"];}
		set{}
	}
	public Emotion disgust{
		get{ return this._emotions["disgust"];}
		set{}
	}
	public Emotion disapproval{
		get{ return this._emotions["disapproval"];}
		set{}
	}
	public Emotion judgmental{
		get{ return this._emotions["judgmental"];}
		set{}
	}
	public Emotion loathing{
		get{ return this._emotions["loathing"];}
		set{}
	}
	public Emotion disappointed{
		get{ return this._emotions["disappointed"];}
		set{}
	}
	public Emotion repugnant{
		get{ return this._emotions["repugnant"];}
		set{}
	}
	public Emotion revolted{
		get{ return this._emotions["revolted"];}
		set{}
	}
	public Emotion awful{
		get{ return this._emotions["awful"];}
		set{}
	}
	public Emotion revulsion{
		get{ return this._emotions["revulsion"];}
		set{}
	}
	public Emotion detestable{
		get{ return this._emotions["detestable"];}
		set{}
	}
	public Emotion avoidance{
		get{ return this._emotions["avoidance"];}
		set{}
	}
	public Emotion aversion{
		get{ return this._emotions["aversion"];}
		set{}
	}
	public Emotion hesitant{
		get{ return this._emotions["hesitant"];}
		set{}
	}
	public Emotion sad{
		get{ return this._emotions["sad"];}
		set{}
	}
	public Emotion guilty{
		get{ return this._emotions["guilty"];}
		set{}
	}
	public Emotion remorseful{
		get{ return this._emotions["remorseful"];}
		set{}
	}
	public Emotion ashamed{
		get{ return this._emotions["ashamed"];}
		set{}
	}
	public Emotion discarded{
		get{ return this._emotions["discarded"];}
		set{}
	}
	public Emotion ignored{
		get{ return this._emotions["ignored"];}
		set{}
	}
	public Emotion victimized{
		get{ return this._emotions["victimized"];}
		set{}
	}
	public Emotion despair{
		get{ return this._emotions["despair"];}
		set{}
	}
	public Emotion powerless{
		get{ return this._emotions["powerless"];}
		set{}
	}
	public Emotion vulnerable{
		get{ return this._emotions["vulnerable"];}
		set{}
	}
	public Emotion depressed{
		get{ return this._emotions["depressed"];}
		set{}
	}
	public Emotion lesser{
		get{ return this._emotions["lesser"];}
		set{}
	}
	public Emotion empty{
		get{ return this._emotions["empty"];}
		set{}
	}
	public Emotion lonely{
		get{ return this._emotions["lonely"];}
		set{}
	}
	public Emotion abandoned{
		get{ return this._emotions["abandoned"];}
		set{}
	}
	public Emotion isolated{
		get{ return this._emotions["isolated"];}
		set{}
	}
	public Emotion bored{
		get{ return this._emotions["bored"];}
		set{}
	}
	public Emotion apathetic{
		get{ return this._emotions["apathetic"];}
		set{}
	}
	public Emotion indifferent{
		get{ return this._emotions["indifferent"];}
		set{}
	}
	public Emotion happy{
		get{ return this._emotions["happy"];}
		set{}
	}
	public Emotion optimistic{
		get{ return this._emotions["optimistic"];}
		set{}
	}
	public Emotion inspired{
		get{ return this._emotions["inspired"];}
		set{}
	}
	public Emotion open{
		get{ return this._emotions["open"];}
		set{}
	}
	public Emotion intimate{
		get{ return this._emotions["intimate"];}
		set{}
	}
	public Emotion playful{
		get{ return this._emotions["playful"];}
		set{}
	}
	public Emotion sensitive{
		get{ return this._emotions["sensitive"];}
		set{}
	}
	public Emotion peaceful{
		get{ return this._emotions["peaceful"];}
		set{}
	}
	public Emotion hopeful{
		get{ return this._emotions["hopeful"];}
		set{}
	}
	public Emotion loving{
		get{ return this._emotions["loving"];}
		set{}
	}
	public Emotion powerful{
		get{ return this._emotions["powerful"];}
		set{}
	}
	public Emotion provocative{
		get{ return this._emotions["provocative"];}
		set{}
	}
	public Emotion courageous{
		get{ return this._emotions["courageous"];}
		set{}
	}
	public Emotion accepted{
		get{ return this._emotions["accepted"];}
		set{}
	}
	public Emotion fulfilled{
		get{ return this._emotions["fulfilled"];}
		set{}
	}
	public Emotion respected{
		get{ return this._emotions["respected"];}
		set{}
	}
	public Emotion proud{
		get{ return this._emotions["proud"];}
		set{}
	}
	public Emotion confident{
		get{ return this._emotions["confident"];}
		set{}
	}
	public Emotion important{
		get{ return this._emotions["important"];}
		set{}
	}
	public Emotion interested{
		get{ return this._emotions["interested"];}
		set{}
	}
	public Emotion inquisitive{
		get{ return this._emotions["inquisitive"];}
		set{}
	}
	public Emotion amused{
		get{ return this._emotions["amused"];}
		set{}
	}
	public Emotion joyful{
		get{ return this._emotions["joyful"];}
		set{}
	}
	public Emotion ecstatic{
		get{ return this._emotions["ecstatic"];}
		set{}
	}
	public Emotion liberated{
		get{ return this._emotions["liberated"];}
		set{}
	}
	public Emotion surprise{
		get{ return this._emotions["surprise"];}
		set{}
	}
	public Emotion excited{
		get{ return this._emotions["excited"];}
		set{}
	}
	public Emotion energetic{
		get{ return this._emotions["energetic"];}
		set{}
	}
	public Emotion eager{
		get{ return this._emotions["eager"];}
		set{}
	}
	public Emotion amazed{
		get{ return this._emotions["amazed"];}
		set{}
	}
	public Emotion awe{
		get{ return this._emotions["awe"];}
		set{}
	}
	public Emotion astonished{
		get{ return this._emotions["astonished"];}
		set{}
	}
	public Emotion confused{
		get{ return this._emotions["confused"];}
		set{}
	}
	public Emotion perplexed{
		get{ return this._emotions["perplexed"];}
		set{}
	}
	public Emotion disillusioned{
		get{ return this._emotions["disillusioned"];}
		set{}
	}
	public Emotion startled{
		get{ return this._emotions["startled"];}
		set{}
	}
	public Emotion dismayed{
		get{ return this._emotions["dismayed"];}
		set{}
	}
	public Emotion shocked{
		get{ return this._emotions["shocked"];}
		set{}
	}

	public static Dictionary<string,Emotion> getDefaultWheal(){
		Dictionary<string,Emotion> dic = new Dictionary<string,Emotion >();

		Emotion fear = new Fear();
		dic.Add("Fear",fear);
		Emotion scared = new Scared();
		dic.Add("Scared",scared);
		Emotion terrified = new Terrified();
		dic.Add("Terrified",terrified);
		Emotion frightened = new Frightened();
		dic.Add("Frightened",frightened);
		Emotion anxious = new Anxious();
		dic.Add("Anxious",anxious);
		Emotion overwhelmed = new Overwhelmed();
		dic.Add("Overwhelmed",overwhelmed);
		Emotion worried = new Worried();
		dic.Add("Worried",worried);
		Emotion apprehensive = new Apprehensive();
		dic.Add("Apprehensive",apprehensive);
		Emotion inadequate = new Inadequate();
		dic.Add("Inadequate",inadequate);
		Emotion inferior = new Inferior();
		dic.Add("Inferior",inferior);
		Emotion submissive = new Submissive();
		dic.Add("Submissive",submissive);
		Emotion worthless = new Worthless();
		dic.Add("Worthless",worthless);
		Emotion insignificant = new Insignificant();
		dic.Add("Insignificant",insignificant);
		Emotion rejected = new Rejected();
		dic.Add("Rejected",rejected);
		Emotion deficient = new Deficient();
		dic.Add("Deficient",deficient);
		Emotion alienated = new Alienated();
		dic.Add("Alienated",alienated);
		Emotion humiliated = new Humiliated();
		dic.Add("Humiliated",humiliated);
		Emotion disrespected = new Disrespected();
		dic.Add("Disrespected",disrespected);
		Emotion ridiculed = new Ridiculed();
		dic.Add("Ridiculed",ridiculed);
		Emotion anger = new Anger();
		dic.Add("Anger",anger);
		Emotion hurt = new Hurt();
		dic.Add("Hurt",hurt);
		Emotion embarrassed = new Embarrassed();
		dic.Add("Embarrassed",embarrassed);
		Emotion devastated = new Devastated();
		dic.Add("Devastated",devastated);
		Emotion threatened = new Threatened();
		dic.Add("Threatened",threatened);
		Emotion insecure = new Insecure();
		dic.Add("Insecure",insecure);
		Emotion jealous = new Jealous();
		dic.Add("Jealous",jealous);
		Emotion hateful = new Hateful();
		dic.Add("Hateful",hateful);
		Emotion resentful = new Resentful();
		dic.Add("Resentful",resentful);
		Emotion violated = new Violated();
		dic.Add("Violated",violated);
		Emotion mad = new Mad();
		dic.Add("Mad",mad);
		Emotion furious = new Furious();
		dic.Add("Furious",furious);
		Emotion enraged = new Enraged();
		dic.Add("Enraged",enraged);
		Emotion aggressive = new Aggressive();
		dic.Add("Aggressive",aggressive);
		Emotion provoked = new Provoked();
		dic.Add("Provoked",provoked);
		Emotion hostile = new Hostile();
		dic.Add("Hostile",hostile);
		Emotion frustrated = new Frustrated();
		dic.Add("Frustrated",frustrated);
		Emotion infuriated = new Infuriated();
		dic.Add("Infuriated",infuriated);
		Emotion irritated = new Irritated();
		dic.Add("Irritated",irritated);
		Emotion distant = new Distant();
		dic.Add("Distant",distant);
		Emotion withdrawn = new Withdrawn();
		dic.Add("Withdrawn",withdrawn);
		Emotion suspicious = new Suspicious();
		dic.Add("Suspicious",suspicious);
		Emotion critical = new Critical();
		dic.Add("Critical",critical);
		Emotion skeptical = new Skeptical();
		dic.Add("Skeptical",skeptical);
		Emotion sarcastic = new Sarcastic();
		dic.Add("Sarcastic",sarcastic);
		Emotion disgust = new Disgust();
		dic.Add("Disgust",disgust);
		Emotion disapproval = new Disapproval();
		dic.Add("Disapproval",disapproval);
		Emotion judgmental = new Judgmental();
		dic.Add("Judgmental",judgmental);
		Emotion loathing = new Loathing();
		dic.Add("Loathing",loathing);
		Emotion disappointed = new Disappointed();
		dic.Add("Disappointed",disappointed);
		Emotion repugnant = new Repugnant();
		dic.Add("Repugnant",repugnant);
		Emotion revolted = new Revolted();
		dic.Add("Revolted",revolted);
		Emotion awful = new Awful();
		dic.Add("Awful",awful);
		Emotion revulsion = new Revulsion();
		dic.Add("Revulsion",revulsion);
		Emotion detestable = new Detestable();
		dic.Add("Detestable",detestable);
		Emotion avoidance = new Avoidance();
		dic.Add("Avoidance",avoidance);
		Emotion aversion = new Aversion();
		dic.Add("Aversion",aversion);
		Emotion hesitant = new Hesitant();
		dic.Add("Hesitant",hesitant);
		Emotion sad = new Sad();
		dic.Add("Sad",sad);
		Emotion guilty = new Guilty();
		dic.Add("Guilty",guilty);
		Emotion remorseful = new Remorseful();
		dic.Add("Remorseful",remorseful);
		Emotion ashamed = new Ashamed();
		dic.Add("Ashamed",ashamed);
		Emotion discarded = new Discarded();
		dic.Add("Discarded",discarded);
		Emotion ignored = new Ignored();
		dic.Add("Ignored",ignored);
		Emotion victimized = new Victimized();
		dic.Add("Victimized",victimized);
		Emotion despair = new Despair();
		dic.Add("Despair",despair);
		Emotion powerless = new Powerless();
		dic.Add("Powerless",powerless);
		Emotion vulnerable = new Vulnerable();
		dic.Add("Vulnerable",vulnerable);
		Emotion depressed = new Depressed();
		dic.Add("Depressed",depressed);
		Emotion lesser = new Lesser();
		dic.Add("Lesser",lesser);
		Emotion empty = new Empty();
		dic.Add("Empty",empty);
		Emotion lonely = new Lonely();
		dic.Add("Lonely",lonely);
		Emotion abandoned = new Abandoned();
		dic.Add("Abandoned",abandoned);
		Emotion isolated = new Isolated();
		dic.Add("Isolated",isolated);
		Emotion bored = new Bored();
		dic.Add("Bored",bored);
		Emotion apathetic = new Apathetic();
		dic.Add("Apathetic",apathetic);
		Emotion indifferent = new Indifferent();
		dic.Add("Indifferent",indifferent);
		Emotion happy = new Happy();
		dic.Add("Happy",happy);
		Emotion optimistic = new Optimistic();
		dic.Add("Optimistic",optimistic);
		Emotion inspired = new Inspired();
		dic.Add("Inspired",inspired);
		Emotion open = new Open();
		dic.Add("Open",open);
		Emotion intimate = new Intimate();
		dic.Add("Intimate",intimate);
		Emotion playful = new Playful();
		dic.Add("Playful",playful);
		Emotion sensitive = new Sensitive();
		dic.Add("Sensitive",sensitive);
		Emotion peaceful = new Peaceful();
		dic.Add("Peaceful",peaceful);
		Emotion hopeful = new Hopeful();
		dic.Add("Hopeful",hopeful);
		Emotion loving = new Loving();
		dic.Add("Loving",loving);
		Emotion powerful = new Powerful();
		dic.Add("Powerful",powerful);
		Emotion provocative = new Provocative();
		dic.Add("Provocative",provocative);
		Emotion courageous = new Courageous();
		dic.Add("Courageous",courageous);
		Emotion accepted = new Accepted();
		dic.Add("Accepted",accepted);
		Emotion fulfilled = new Fulfilled();
		dic.Add("Fulfilled",fulfilled);
		Emotion respected = new Respected();
		dic.Add("Respected",respected);
		Emotion proud = new Proud();
		dic.Add("Proud",proud);
		Emotion confident = new Confident();
		dic.Add("Confident",confident);
		Emotion important = new Important();
		dic.Add("Important",important);
		Emotion interested = new Interested();
		dic.Add("Interested",interested);
		Emotion inquisitive = new Inquisitive();
		dic.Add("Inquisitive",inquisitive);
		Emotion amused = new Amused();
		dic.Add("Amused",amused);
		Emotion joyful = new Joyful();
		dic.Add("Joyful",joyful);
		Emotion ecstatic = new Ecstatic();
		dic.Add("Ecstatic",ecstatic);
		Emotion liberated = new Liberated();
		dic.Add("Liberated",liberated);
		Emotion surprise = new Surprise();
		dic.Add("Surprise",surprise);
		Emotion excited = new Excited();
		dic.Add("Excited",excited);
		Emotion energetic = new Energetic();
		dic.Add("Energetic",energetic);
		Emotion eager = new Eager();
		dic.Add("Eager",eager);
		Emotion amazed = new Amazed();
		dic.Add("Amazed",amazed);
		Emotion awe = new Awe();
		dic.Add("Awe",awe);
		Emotion astonished = new Astonished();
		dic.Add("Astonished",astonished);
		Emotion confused = new Confused();
		dic.Add("Confused",confused);
		Emotion perplexed = new Perplexed();
		dic.Add("Perplexed",perplexed);
		Emotion disillusioned = new Disillusioned();
		dic.Add("Disillusioned",disillusioned);
		Emotion startled = new Startled();
		dic.Add("Startled",startled);
		Emotion dismayed = new Dismayed();
		dic.Add("Dismayed",dismayed);
		Emotion shocked = new Shocked();
		dic.Add("Shocked",shocked);
		
		
		//siblings
		
		fear.olderSibling = anger;
		scared.olderSibling = anxious;
		terrified.olderSibling = frightened;
		frightened.olderSibling = overwhelmed;
		anxious.olderSibling = apprehensive;
		overwhelmed.olderSibling = worried;
		worried.olderSibling = inadequate;
		apprehensive.olderSibling = submissive;
		inadequate.olderSibling = inferior;
		inferior.olderSibling = worthless;
		submissive.olderSibling = rejected;
		worthless.olderSibling = insignificant;
		insignificant.olderSibling = deficient;
		rejected.olderSibling = humiliated;
		deficient.olderSibling = alienated;
		alienated.olderSibling = disrespected;
		humiliated.olderSibling = hurt;
		disrespected.olderSibling = ridiculed;
		ridiculed.olderSibling = embarrassed;
		anger.olderSibling = disgust;
		hurt.olderSibling = threatened;
		embarrassed.olderSibling = devastated;
		devastated.olderSibling = insecure;
		threatened.olderSibling = hateful;
		insecure.olderSibling = jealous;
		jealous.olderSibling = resentful;
		hateful.olderSibling = mad;
		resentful.olderSibling = violated;
		violated.olderSibling = furious;
		mad.olderSibling = aggressive;
		furious.olderSibling = enraged;
		enraged.olderSibling = provoked;
		aggressive.olderSibling = frustrated;
		provoked.olderSibling = hostile;
		hostile.olderSibling = infuriated;
		frustrated.olderSibling = distant;
		infuriated.olderSibling = irritated;
		irritated.olderSibling = withdrawn;
		distant.olderSibling = critical;
		withdrawn.olderSibling = suspicious;
		suspicious.olderSibling = skeptical;
		critical.olderSibling = disapproval;
		skeptical.olderSibling = sarcastic;
		sarcastic.olderSibling = judgmental;
		disgust.olderSibling = sad;
		disapproval.olderSibling = disappointed;
		judgmental.olderSibling = loathing;
		loathing.olderSibling = repugnant;
		disappointed.olderSibling = awful;
		repugnant.olderSibling = revolted;
		revolted.olderSibling = revulsion;
		awful.olderSibling = avoidance;
		revulsion.olderSibling = detestable;
		detestable.olderSibling = aversion;
		avoidance.olderSibling = guilty;
		aversion.olderSibling = hesitant;
		hesitant.olderSibling = remorseful;
		sad.olderSibling = happy;
		guilty.olderSibling = discarded;
		remorseful.olderSibling = ashamed;
		ashamed.olderSibling = ignored;
		discarded.olderSibling = despair;
		ignored.olderSibling = victimized;
		victimized.olderSibling = powerless;
		despair.olderSibling = depressed;
		powerless.olderSibling = vulnerable;
		vulnerable.olderSibling = lesser;
		depressed.olderSibling = lonely;
		lesser.olderSibling = empty;
		empty.olderSibling = abandoned;
		lonely.olderSibling = bored;
		abandoned.olderSibling = isolated;
		isolated.olderSibling = apathetic;
		bored.olderSibling = optimistic;
		apathetic.olderSibling = indifferent;
		indifferent.olderSibling = inspired;
		happy.olderSibling = surprise;
		optimistic.olderSibling = intimate;
		inspired.olderSibling = open;
		open.olderSibling = playful;
		intimate.olderSibling = peaceful;
		playful.olderSibling = sensitive;
		sensitive.olderSibling = hopeful;
		peaceful.olderSibling = powerful;
		hopeful.olderSibling = loving;
		loving.olderSibling = provocative;
		powerful.olderSibling = accepted;
		provocative.olderSibling = courageous;
		courageous.olderSibling = fulfilled;
		accepted.olderSibling = proud;
		fulfilled.olderSibling = respected;
		respected.olderSibling = confident;
		proud.olderSibling = interested;
		confident.olderSibling = important;
		important.olderSibling = inquisitive;
		interested.olderSibling = joyful;
		inquisitive.olderSibling = amused;
		amused.olderSibling = ecstatic;
		joyful.olderSibling = excited;
		ecstatic.olderSibling = liberated;
		liberated.olderSibling = energetic;
		surprise.olderSibling = fear;
		excited.olderSibling = amazed;
		energetic.olderSibling = eager;
		eager.olderSibling = awe;
		amazed.olderSibling = confused;
		awe.olderSibling = astonished;
		astonished.olderSibling = perplexed;
		confused.olderSibling = startled;
		perplexed.olderSibling = disillusioned;
		disillusioned.olderSibling = dismayed;
		startled.olderSibling = scared;
		dismayed.olderSibling = shocked;
		shocked.olderSibling = terrified;
		
		
		//children
		
		fear.children = new Emotion[2]{terrified, frightened};
		fear.children = new Emotion[2]{overwhelmed, worried};
		fear.children = new Emotion[2]{inadequate, inferior};
		fear.children = new Emotion[2]{worthless, insignificant};
		fear.children = new Emotion[2]{deficient, alienated};
		fear.children = new Emotion[2]{disrespected, ridiculed};
		fear.children = new Emotion[6]{scared, anxious, apprehensive, submissive, rejected, humiliated};
		anger.children = new Emotion[2]{embarrassed, devastated};
		anger.children = new Emotion[2]{insecure, jealous};
		anger.children = new Emotion[2]{resentful, violated};
		anger.children = new Emotion[2]{furious, enraged};
		anger.children = new Emotion[2]{provoked, hostile};
		anger.children = new Emotion[2]{infuriated, irritated};
		anger.children = new Emotion[2]{withdrawn, suspicious};
		anger.children = new Emotion[2]{skeptical, sarcastic};
		anger.children = new Emotion[8]{hurt, threatened, hateful, mad, aggressive, frustrated, distant, critical};
		disgust.children = new Emotion[2]{judgmental, loathing};
		disgust.children = new Emotion[2]{repugnant, revolted};
		disgust.children = new Emotion[2]{revulsion, detestable};
		disgust.children = new Emotion[2]{aversion, hesitant};
		disgust.children = new Emotion[4]{disapproval, disappointed, awful, avoidance};
		sad.children = new Emotion[2]{remorseful, ashamed};
		sad.children = new Emotion[2]{ignored, victimized};
		sad.children = new Emotion[2]{powerless, vulnerable};
		sad.children = new Emotion[2]{lesser, empty};
		sad.children = new Emotion[2]{abandoned, isolated};
		sad.children = new Emotion[2]{apathetic, indifferent};
		sad.children = new Emotion[6]{guilty, discarded, despair, depressed, lonely, bored};
		happy.children = new Emotion[2]{inspired, open};
		happy.children = new Emotion[2]{playful, sensitive};
		happy.children = new Emotion[2]{hopeful, loving};
		happy.children = new Emotion[2]{provocative, courageous};
		happy.children = new Emotion[2]{fulfilled, respected};
		happy.children = new Emotion[2]{confident, important};
		happy.children = new Emotion[2]{inquisitive, amused};
		happy.children = new Emotion[2]{ecstatic, liberated};
		happy.children = new Emotion[8]{optimistic, intimate, peaceful, powerful, accepted, proud, interested, joyful};
		surprise.children = new Emotion[2]{energetic, eager};
		surprise.children = new Emotion[2]{awe, astonished};
		surprise.children = new Emotion[2]{perplexed, disillusioned};
		surprise.children = new Emotion[2]{dismayed, shocked};
		surprise.children = new Emotion[4]{excited, amazed, confused, startled};

		return dic;
	}
}
