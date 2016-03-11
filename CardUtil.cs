using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class CardUtil
    {
        public static Card LoadCardFromId(int cardId)
        {
            switch (cardId)
            {

                case 0:
                    return new CardAcidicSwampOoze();
                case 1:
                    return new CardArchmage();
                case 2:
                    return new CardBloodfenRaptor();
                case 3:
                    return new CardBluegillWarrior();
                case 4:
                    return new CardBootyBayBodyguard();
                case 5:
                    return new CardBoulderfistOgre();
                case 6:
                    return new CardChillwindYeti();
                case 7:
                    return new CardCoreHound();
                case 8:
                    return new CardDalaranMage();
                case 9:
                    return new CardDarkscaleHealer();
                case 10:
                    return new CardDragonlingMechanic();
                case 11:
                    return new CardElvenArcher();
                case 12:
                    return new CardFrostwolfGrunt();
                case 13:
                    return new CardFrostwolfWarlord();
                case 14:
                    return new CardGnomishInventor();
                case 15:
                    return new CardGoldshireFootman();
                case 16:
                    return new CardGrimscaleOracle();
                case 17:
                    return new CardGurubashiBerserker();
                case 18:
                    return new CardIronforgeRifleman();
                case 19:
                    return new CardIronfurGrizzly();
                case 20:
                    return new CardKoboldGeomancer();
                case 21:
                    return new CardLordoftheArena();
                case 22:
                    return new CardMagmaRager();
                case 23:
                    return new CardMurlocRaider();
                case 24:
                    return new CardMurlocTidehunter();
                case 25:
                    return new CardNightblade();
                case 26:
                    return new CardNoviceEngineer();
                case 27:
                    return new CardOasisSnapjaw();
                case 28:
                    return new CardOgreMagi();
                case 29:
                    return new CardRaidLeader();
                case 30:
                    return new CardRazorfenHunter();
                case 31:
                    return new CardRecklessRocketeer();
                case 32:
                    return new CardRiverCrocolisk();
                case 33:
                    return new CardSenjinShieldmasta();
                case 34:
                    return new CardShatteredSunCleric();
                case 35:
                    return new CardSilverbackPatriarch();
                case 36:
                    return new CardStonetuskBoar();
                case 37:
                    return new CardStormpikeCommando();
                case 38:
                    return new CardStormwindChampion();
                case 39:
                    return new CardStormwindKnight();
                case 40:
                    return new CardVoodooDoctor();
                case 41:
                    return new CardWarGolem();
                case 42:
                    return new CardWolfrider();
                case 1000:
                    return new CardClaw();
                case 1001:
                    return new CardHealingTouch();
                case 1002:
                    return new CardInnervate();
                case 1003:
                    return new CardIronbarkProtector();
                case 1004:
                    return new CardMarkoftheWild();
                case 1005:
                    return new CardMoonfire();
                case 1006:
                    return new CardSavageRoar();
                case 1007:
                    return new CardStarfire();
                case 1008:
                    return new CardSwipe();
                case 1009:
                    return new CardWildGrowth();
                case 2000:
                    return new CardAnimalCompanion();
                case 2001:
                    return new CardArcaneShot();
                case 2002:
                    return new CardHoundmaster();
                case 2003:
                    return new CardHuntersMark();
                case 2004:
                    return new CardKillCommand();
                case 2005:
                    return new CardMultiShot();
                case 2006:
                    return new CardStarvingBuzzard();
                case 2007:
                    return new CardTimberWolf();
                case 2008:
                    return new CardTracking();
                case 2009:
                    return new CardTundraRhino();
                case 3000:
                    return new CardArcaneExplosion();
                case 3001:
                    return new CardArcaneIntellect();
                case 3002:
                    return new CardArcaneMissiles();
                case 3003:
                    return new CardFireball();
                case 3004:
                    return new CardFlamestrike();
                case 3005:
                    return new CardFrostNova();
                case 3006:
                    return new CardFrostbolt();
                case 3007:
                    return new CardMirrorImage();
                case 3008:
                    return new CardPolymorph();
                case 3009:
                    return new CardWaterElemental();
                case 4000:
                    return new CardBlessingofKings();
                case 4001:
                    return new CardBlessingofMight();
                case 4002:
                    return new CardConsecration();
                case 4003:
                    return new CardGuardianofKings();
                case 4004:
                    return new CardHammerofWrath();
                case 4005:
                    return new CardHandofProtection();
                case 4006:
                    return new CardHolyLight();
                case 4007:
                    return new CardHumility();
                case 4008:
                    return new CardLightsJustice();
                case 4009:
                    return new CardTruesilverChampion();
                case 5000:
                    return new CardDivineSpirit();
                case 5001:
                    return new CardHolyNova();
                case 5002:
                    return new CardHolySmite();
                case 5003:
                    return new CardMindBlast();
                case 5004:
                    return new CardMindControl();
                case 5005:
                    return new CardMindVision();
                case 5006:
                    return new CardNorthshireCleric();
                case 5007:
                    return new CardPowerWordShield();
                case 5008:
                    return new CardShadowWordDeath();
                case 5009:
                    return new CardShadowWordPain();
                case 6000:
                    return new CardAssassinate();
                case 6001:
                    return new CardAssassinsBlade();
                case 6002:
                    return new CardBackstab();
                case 6003:
                    return new CardDeadlyPoison();
                case 6004:
                    return new CardFanofKnives();
                case 6005:
                    return new CardSap();
                case 6006:
                    return new CardShiv();
                case 6007:
                    return new CardSinisterStrike();
                case 6008:
                    return new CardSprint();
                case 6009:
                    return new CardVanish();
                case 7000:
                    return new CardAncestralHealing();
                case 7001:
                    return new CardBloodlust();
                case 7002:
                    return new CardFireElemental();
                case 7003:
                    return new CardFlametongueTotem();
                case 7004:
                    return new CardFrostShock();
                case 7005:
                    return new CardHex();
                case 7006:
                    return new CardRockbiterWeapon();
                case 7007:
                    return new CardTotemicMight();
                case 7008:
                    return new CardWindfury();
                case 7009:
                    return new CardWindspeaker();
                case 8000:
                    return new CardCorruption();
                case 8001:
                    return new CardDrainLife();
                case 8002:
                    return new CardDreadInfernal();
                case 8003:
                    return new CardHellfire();
                case 8004:
                    return new CardMortalCoil();
                case 8005:
                    return new CardSacrificialPact();
                case 8006:
                    return new CardShadowBolt();
                case 8007:
                    return new CardSoulfire();
                case 8008:
                    return new CardSuccubus();
                case 8009:
                    return new CardVoidwalker();
                case 9000:
                    return new CardArcaniteReaper();
                case 9001:
                    return new CardCharge();
                case 9002:
                    return new CardCleave();
                case 9003:
                    return new CardExecute();
                case 9004:
                    return new CardFieryWarAxe();
                case 9005:
                    return new CardHeroicStrike();
                case 9006:
                    return new CardKorKronElite();
                case 9007:
                    return new CardShieldBlock();
                case 9008:
                    return new CardWarsongCommander();
                case 9009:
                    return new CardWhirlwind();
                case 100000:
                    return new CardAbomination();
                case 100001:
                    return new CardAbusiveSergeant();
                case 100002:
                    return new CardAcolyteofPain();
                case 100003:
                    return new CardAlarmoBot();
                case 100004:
                    return new CardAlexstrasza();
                case 100005:
                    return new CardAmaniBerserker();
                case 100006:
                    return new CardAncientBrewmaster();
                case 100007:
                    return new CardAncientMage();
                case 100008:
                    return new CardAncientWatcher();
                case 100009:
                    return new CardAngryChicken();
                case 100010:
                    return new CardArcaneGolem();
                case 100011:
                    return new CardArgentCommander();
                case 100012:
                    return new CardArgentSquire();
                case 100013:
                    return new CardAzureDrake();
                case 100014:
                    return new CardBaronGeddon();
                case 100015:
                    return new CardBigGameHunter();
                case 100016:
                    return new CardBloodKnight();
                case 100017:
                    return new CardBloodmageThalnos();
                case 100018:
                    return new CardBloodsailCorsair();
                case 100019:
                    return new CardBloodsailRaider();
                case 100020:
                    return new CardCairneBloodhoof();
                case 100021:
                    return new CardCaptainGreenskin();
                case 100022:
                    return new CardCaptainsParrot();
                case 100023:
                    return new CardColdlightOracle();
                case 100024:
                    return new CardColdlightSeer();
                case 100025:
                    return new CardCrazedAlchemist();
                case 100026:
                    return new CardCultMaster();
                case 100027:
                    return new CardDarkIronDwarf();
                case 100028:
                    return new CardDeathwing();
                case 100029:
                    return new CardDefenderofArgus();
                case 100030:
                    return new CardDemolisher();
                case 100031:
                    return new CardDireWolfAlpha();
                case 100032:
                    return new CardDoomsayer();
                case 100033:
                    return new CardDreadCorsair();
                case 100034:
                    return new CardEarthenRingFarseer();
                case 100035:
                    return new CardEmperorCobra();
                case 100036:
                    return new CardFacelessManipulator();
                case 100037:
                    return new CardFaerieDragon();
                case 100038:
                    return new CardFenCreeper();
                case 100039:
                    return new CardFlesheatingGhoul();
                case 100040:
                    return new CardFrostElemental();
                case 100041:
                    return new CardGadgetzanAuctioneer();
                case 100042:
                    return new CardGruul();
                case 100043:
                    return new CardHarrisonJones();
                case 100044:
                    return new CardHarvestGolem();
                case 100045:
                    return new CardHogger();
                case 100046:
                    return new CardHungryCrab();
                case 100047:
                    return new CardIllidanStormrage();
                case 100048:
                    return new CardImpMaster();
                case 100049:
                    return new CardInjuredBlademaster();
                case 100050:
                    return new CardIronbeakOwl();
                case 100051:
                    return new CardJunglePanther();
                case 100052:
                    return new CardKingMukla();
                case 100053:
                    return new CardKnifeJuggler();
                case 100054:
                    return new CardLeeroyJenkins();
                case 100055:
                    return new CardLeperGnome();
                case 100056:
                    return new CardLightwarden();
                case 100057:
                    return new CardLootHoarder();
                case 100058:
                    return new CardLorewalkerCho();
                case 100059:
                    return new CardMadBomber();
                case 100060:
                    return new CardMalygos();
                case 100061:
                    return new CardManaAddict();
                case 100062:
                    return new CardManaWraith();
                case 100063:
                    return new CardMasterSwordsmith();
                case 100064:
                    return new CardMillhouseManastorm();
                case 100065:
                    return new CardMindControlTech();
                case 100066:
                    return new CardMogushanWarden();
                case 100067:
                    return new CardMoltenGiant();
                case 100068:
                    return new CardMountainGiant();
                case 100069:
                    return new CardMurlocTidecaller();
                case 100070:
                    return new CardMurlocWarleader();
                case 100071:
                    return new CardNatPagle();
                case 100072:
                    return new CardNozdormu();
                case 100073:
                    return new CardOldMurkEye();
                case 100074:
                    return new CardOnyxia();
                case 100075:
                    return new CardPintSizedSummoner();
                case 100076:
                    return new CardPriestessofElune();
                case 100077:
                    return new CardQuestingAdventurer();
                case 100078:
                    return new CardRagingWorgen();
                case 100079:
                    return new CardRagnarostheFirelord();
                case 100080:
                    return new CardRavenholdtAssassin();
                case 100081:
                    return new CardScarletCrusader();
                case 100082:
                    return new CardSeaGiant();
                case 100083:
                    return new CardSecretkeeper();
                case 100084:
                    return new CardShieldbearer();
                case 100085:
                    return new CardSilverHandKnight();
                case 100086:
                    return new CardSilvermoonGuardian();
                case 100087:
                    return new CardSouthseaCaptain();
                case 100088:
                    return new CardSouthseaDeckhand();
                case 100089:
                    return new CardSpellbreaker();
                case 100090:
                    return new CardSpitefulSmith();
                case 100091:
                    return new CardStampedingKodo();
                case 100092:
                    return new CardStranglethornTiger();
                case 100093:
                    return new CardSunfuryProtector();
                case 100094:
                    return new CardSunwalker();
                case 100095:
                    return new CardSylvanasWindrunner();
                case 100096:
                    return new CardTaurenWarrior();
                case 100097:
                    return new CardTheBeast();
                case 100098:
                    return new CardTheBlackKnight();
                case 100099:
                    return new CardThrallmarFarseer();
                case 100100:
                    return new CardTinkmasterOverspark();
                case 100101:
                    return new CardTwilightDrake();
                case 100102:
                    return new CardVentureCoMercenary();
                case 100103:
                    return new CardVioletTeacher();
                case 100104:
                    return new CardWildPyromancer();
                case 100105:
                    return new CardWindfuryHarpy();
                case 100106:
                    return new CardWisp();
                case 100107:
                    return new CardWorgenInfiltrator();
                case 100108:
                    return new CardYoungDragonhawk();
                case 100109:
                    return new CardYoungPriestess();
                case 100110:
                    return new CardYouthfulBrewmaster();
                case 100111:
                    return new CardYsera();
                case 101000:
                    return new CardAncientofLore();
                case 101001:
                    return new CardAncientofWar();
                case 101002:
                    return new CardBite();
                case 101003:
                    return new CardCenarius();
                case 101004:
                    return new CardDruidoftheClaw();
                case 101005:
                    return new CardForceofNature();
                case 101006:
                    return new CardKeeperoftheGrove();
                case 101007:
                    return new CardMarkofNature();
                case 101008:
                    return new CardNaturalize();
                case 101009:
                    return new CardNourish();
                case 101010:
                    return new CardPoweroftheWild();
                case 101011:
                    return new CardSavagery();
                case 101012:
                    return new CardSouloftheForest();
                case 101013:
                    return new CardStarfall();
                case 101014:
                    return new CardWrath();
                case 102000:
                    return new CardBestialWrath();
                case 102001:
                    return new CardDeadlyShot();
                case 102002:
                    return new CardEaglehornBow();
                case 102003:
                    return new CardExplosiveShot();
                case 102004:
                    return new CardExplosiveTrap();
                case 102005:
                    return new CardFlare();
                case 102006:
                    return new CardFreezingTrap();
                case 102007:
                    return new CardGladiatorsLongbow();
                case 102008:
                    return new CardKingKrush();
                case 102009:
                    return new CardMisdirection();
                case 102010:
                    return new CardSavannahHighmane();
                case 102011:
                    return new CardScavengingHyena();
                case 102012:
                    return new CardSnakeTrap();
                case 102013:
                    return new CardSnipe();
                case 102014:
                    return new CardUnleashtheHounds();
                case 103000:
                    return new CardArchmageAntonidas();
                case 103001:
                    return new CardBlizzard();
                case 103002:
                    return new CardConeofCold();
                case 103003:
                    return new CardCounterspell();
                case 103004:
                    return new CardEtherealArcanist();
                case 103005:
                    return new CardIceBarrier();
                case 103006:
                    return new CardIceBlock();
                case 103007:
                    return new CardIceLance();
                case 103008:
                    return new CardKirinTorMage();
                case 103009:
                    return new CardManaWyrm();
                case 103010:
                    return new CardMirrorEntity();
                case 103011:
                    return new CardPyroblast();
                case 103012:
                    return new CardSorcerersApprentice();
                case 103013:
                    return new CardSpellbender();
                case 103014:
                    return new CardVaporize();
                case 104000:
                    return new CardAldorPeacekeeper();
                case 104001:
                    return new CardArgentProtector();
                case 104002:
                    return new CardAvengingWrath();
                case 104003:
                    return new CardBlessedChampion();
                case 104004:
                    return new CardBlessingofWisdom();
                case 104005:
                    return new CardDivineFavor();
                case 104006:
                    return new CardEquality();
                case 104007:
                    return new CardEyeforanEye();
                case 104008:
                    return new CardHolyWrath();
                case 104009:
                    return new CardLayonHands();
                case 104010:
                    return new CardNobleSacrifice();
                case 104011:
                    return new CardRedemption();
                case 104012:
                    return new CardRepentance();
                case 104013:
                    return new CardSwordofJustice();
                case 104014:
                    return new CardTirionFordring();
                case 105000:
                    return new CardAuchenaiSoulpriest();
                case 105001:
                    return new CardCabalShadowPriest();
                case 105002:
                    return new CardCircleofHealing();
                case 105003:
                    return new CardHolyFire();
                case 105004:
                    return new CardInnerFire();
                case 105005:
                    return new CardLightspawn();
                case 105006:
                    return new CardLightwell();
                case 105007:
                    return new CardMassDispel();
                case 105008:
                    return new CardMindgames();
                case 105009:
                    return new CardProphetVelen();
                case 105010:
                    return new CardShadowMadness();
                case 105011:
                    return new CardShadowform();
                case 105012:
                    return new CardSilence();
                case 105013:
                    return new CardTempleEnforcer();
                case 105014:
                    return new CardThoughtsteal();
                case 106000:
                    return new CardBetrayal();
                case 106001:
                    return new CardBladeFlurry();
                case 106002:
                    return new CardColdBlood();
                case 106003:
                    return new CardConceal();
                case 106004:
                    return new CardDefiasRingleader();
                case 106005:
                    return new CardEdwinVanCleef();
                case 106006:
                    return new CardEviscerate();
                case 106007:
                    return new CardHeadcrack();
                case 106008:
                    return new CardKidnapper();
                case 106009:
                    return new CardMasterofDisguise();
                case 106010:
                    return new CardPatientAssassin();
                case 106011:
                    return new CardPerditionsBlade();
                case 106012:
                    return new CardPreparation();
                case 106013:
                    return new CardShadowstep();
                case 106014:
                    return new CardSI7Agent();
                case 107000:
                    return new CardAlAkirtheWindlord();
                case 107001:
                    return new CardAncestralSpirit();
                case 107002:
                    return new CardDoomhammer();
                case 107003:
                    return new CardDustDevil();
                case 107004:
                    return new CardEarthElemental();
                case 107005:
                    return new CardEarthShock();
                case 107006:
                    return new CardFarSight();
                case 107007:
                    return new CardFeralSpirit();
                case 107008:
                    return new CardForkedLightning();
                case 107009:
                    return new CardLavaBurst();
                case 107010:
                    return new CardLightningBolt();
                case 107011:
                    return new CardLightningStorm();
                case 107012:
                    return new CardManaTideTotem();
                case 107013:
                    return new CardStormforgedAxe();
                case 107014:
                    return new CardUnboundElemental();
                case 108000:
                    return new CardBaneofDoom();
                case 108001:
                    return new CardBloodImp();
                case 108002:
                    return new CardDemonfire();
                case 108003:
                    return new CardDoomguard();
                case 108004:
                    return new CardFelguard();
                case 108005:
                    return new CardFlameImp();
                case 108006:
                    return new CardLordJaraxxus();
                case 108007:
                    return new CardPitLord();
                case 108008:
                    return new CardPowerOverwhelming();
                case 108009:
                    return new CardSenseDemons();
                case 108010:
                    return new CardShadowflame();
                case 108011:
                    return new CardSiphonSoul();
                case 108012:
                    return new CardSummoningPortal();
                case 108013:
                    return new CardTwistingNether();
                case 108014:
                    return new CardVoidTerror();
                case 109000:
                    return new CardArathiWeaponsmith();
                case 109001:
                    return new CardArmorsmith();
                case 109002:
                    return new CardBattleRage();
                case 109003:
                    return new CardBrawl();
                case 109004:
                    return new CardCommandingShout();
                case 109005:
                    return new CardCruelTaskmaster();
                case 109006:
                    return new CardFrothingBerserker();
                case 109007:
                    return new CardGorehowl();
                case 109008:
                    return new CardGrommashHellscream();
                case 109009:
                    return new CardInnerRage();
                case 109010:
                    return new CardMortalStrike();
                case 109011:
                    return new CardRampage();
                case 109012:
                    return new CardShieldSlam();
                case 109013:
                    return new CardSlam();
                case 109014:
                    return new CardUpgrade();
                case 200000:
                    return new CardBaronRivendare();
                case 200001:
                    return new CardDancingSwords();
                case 200002:
                    return new CardDeathlord();
                case 200003:
                    return new CardEchoingOoze();
                case 200004:
                    return new CardFeugan();
                case 200005:
                    return new CardHauntedCreeper();
                case 200006:
                    return new CardKelthuzad();
                case 200007:
                    return new CardLoatheb();
                case 200008:
                    return new CardMadScientist();
                case 200009:
                    return new CardMaexxna();
                case 200010:
                    return new CardNerubarWeblord();
                case 200011:
                    return new CardNerubianEgg();
                case 200012:
                    return new CardShadeofNaxxramas();
                case 200013:
                    return new CardSludgeBelcher();
                case 200014:
                    return new CardSpectralKnight();
                case 200015:
                    return new CardStalagg();
                case 200016:
                    return new CardStoneskinGargoyle();
                case 200017:
                    return new CardUndertaker();
                case 200018:
                    return new CardUnstableGhoul();
                case 200019:
                    return new CardWailingSoul();
                case 200020:
                    return new CardZombieChow();
                case 201000:
                    return new CardPoisonSeeds();
                case 202000:
                    return new CardWebspinner();
                case 203000:
                    return new CardDuplicate();
                case 204000:
                    return new CardAvenge();
                case 205000:
                    return new CardDarkCultist();
                case 206000:
                    return new CardAnubarAmbusher();
                case 207000:
                    return new CardReincarnate();
                case 208000:
                    return new CardVoidcaller();
                case 209000:
                    return new CardDeathsBite();
                case 300000:
                    return new CardAnnoyoTron();
                case 300001:
                    return new CardAntiqueHealbot();
                case 300002:
                    return new CardArcaneNullifierX21();
                case 300003:
                    return new CardBlingtron3000();
                case 300004:
                    return new CardBombLobber();
                case 300005:
                    return new CardBurlyRockjawTrogg();
                case 300006:
                    return new CardClockworkGiant();
                case 300007:
                    return new CardClockworkGnome();
                case 300008:
                    return new CardCogmaster();
                case 300009:
                    return new CardDrBoom();
                case 300010:
                    return new CardEnhanceoMechano();
                case 300011:
                    return new CardExplosiveSheep();
                case 300012:
                    return new CardFelReaver();
                case 300013:
                    return new CardFlyingMachine();
                case 300014:
                    return new CardFoeReaper4000();
                case 300015:
                    return new CardForceTankMAX();
                case 300016:
                    return new CardGazlowe();
                case 300017:
                    return new CardGilblinStalker();
                case 300018:
                    return new CardGnomereganInfantry();
                case 300019:
                    return new CardGnomishExperimenter();
                case 300020:
                    return new CardGoblinSapper();
                case 300021:
                    return new CardHemetNesingwary();
                case 300022:
                    return new CardHobgoblin();
                case 300023:
                    return new CardIlluminator();
                case 300024:
                    return new CardJeeves();
                case 300025:
                    return new CardJunkbot();
                case 300026:
                    return new CardKezanMystic();
                case 300027:
                    return new CardLilExorcist();
                case 300028:
                    return new CardLostTallstrider();
                case 300029:
                    return new CardMadderBomber();
                case 300030:
                    return new CardMechanicalYeti();
                case 300031:
                    return new CardMechwarper();
                case 300032:
                    return new CardMekgineerThermaplugg();
                case 300033:
                    return new CardMicroMachine();
                case 300034:
                    return new CardMimironsHead();
                case 300035:
                    return new CardMiniMage();
                case 300036:
                    return new CardMogortheOgre();
                case 300037:
                    return new CardOgreBrute();
                case 300038:
                    return new CardPilotedShredder();
                case 300039:
                    return new CardPilotedSkyGolem();
                case 300040:
                    return new CardPuddlestomper();
                case 300041:
                    return new CardRecombobulator();
                case 300042:
                    return new CardSaltyDog();
                case 300043:
                    return new CardShipsCannon();
                case 300044:
                    return new CardSneedsOldShredder();
                case 300045:
                    return new CardSpiderTank();
                case 300046:
                    return new CardStonesplinterTrogg();
                case 300047:
                    return new CardTargetDummy();
                case 300048:
                    return new CardTinkertownTechnician();
                case 300049:
                    return new CardToshley();
                case 300050:
                    return new CardTroggzortheEarthinator();
                case 301000:
                    return new CardAnodizedRoboCub();
                case 301001:
                    return new CardDarkWispers();
                case 301002:
                    return new CardDruidoftheFang();
                case 301003:
                    return new CardGroveTender();
                case 301004:
                    return new CardMalorne();
                case 301005:
                    return new CardMechBearCat();
                case 301006:
                    return new CardRecycle();
                case 301007:
                    return new CardTreeofLife();
                case 302000:
                    return new CardCallPet();
                case 302001:
                    return new CardCobraShot();
                case 302002:
                    return new CardFeignDeath();
                case 302003:
                    return new CardGahzrilla();
                case 302004:
                    return new CardGlaivezooka();
                case 302005:
                    return new CardKingofBeasts();
                case 302006:
                    return new CardMetaltoothLeaper();
                case 302007:
                    return new CardSteamwheedleSniper();
                case 303000:
                    return new CardEchoofMedivh();
                case 303001:
                    return new CardFlameLeviathan();
                case 303002:
                    return new CardFlamecannon();
                case 303003:
                    return new CardGoblinBlastmage();
                case 303004:
                    return new CardSnowchugger();
                case 303005:
                    return new CardSootSpewer();
                case 303006:
                    return new CardUnstablePortal();
                case 303007:
                    return new CardWeeSpellstopper();
                case 304000:
                    return new CardBolvarFordragon();
                case 304001:
                    return new CardCobaltGuardian();
                case 304002:
                    return new CardCoghammer();
                case 304003:
                    return new CardMusterforBattle();
                case 304004:
                    return new CardQuartermaster();
                case 304005:
                    return new CardScarletPurifier();
                case 304006:
                    return new CardSealofLight();
                case 304007:
                    return new CardShieldedMinibot();
                case 305000:
                    return new CardLightoftheNaaru();
                case 305001:
                    return new CardLightbomb();
                case 305002:
                    return new CardShadowbomber();
                case 305003:
                    return new CardShadowboxer();
                case 305004:
                    return new CardShrinkmeister();
                case 305005:
                    return new CardUpgradedRepairBot();
                case 305006:
                    return new CardVelensChosen();
                case 305007:
                    return new CardVoljin();
                case 306000:
                    return new CardCogmastersWrench();
                case 306001:
                    return new CardGoblinAutoBarber();
                case 306002:
                    return new CardIronSensei();
                case 306003:
                    return new CardOgreNinja();
                case 306004:
                    return new CardOneEyedCheat();
                case 306005:
                    return new CardSabotage();
                case 306006:
                    return new CardTinkersSharpswordOil();
                case 306007:
                    return new CardTradePrinceGallywix();
                case 307000:
                    return new CardAncestorsCall();
                case 307001:
                    return new CardCrackle();
                case 307002:
                    return new CardDunemaulShaman();
                case 307003:
                    return new CardNeptulon();
                case 307004:
                    return new CardPowermace();
                case 307005:
                    return new CardSiltfinSpiritwalker();
                case 307006:
                    return new CardVitalityTotem();
                case 307007:
                    return new CardWhirlingZapomatic();
                case 308000:
                    return new CardAnimaGolem();
                case 308001:
                    return new CardDarkbomb();
                case 308002:
                    return new CardDemonheart();
                case 308003:
                    return new CardFelCannon();
                case 308004:
                    return new CardFloatingWatcher();
                case 308005:
                    return new CardImplosion();
                case 308006:
                    return new CardMalGanis();
                case 308007:
                    return new CardMistressofPain();
                case 309000:
                    return new CardBouncingBlade();
                case 309001:
                    return new CardCrush();
                case 309002:
                    return new CardIronJuggernaut();
                case 309003:
                    return new CardOgreWarmaul();
                case 309004:
                    return new CardScrewjankClunker();
                case 309005:
                    return new CardShieldmaiden();
                case 309006:
                    return new CardSiegeEngine();
                case 309007:
                    return new CardWarbot();
                case 400000:
                    return new CardBlackwingCorruptor();
                case 400001:
                    return new CardBlackwingTechnician();
                case 400002:
                    return new CardChromaggus();
                case 400003:
                    return new CardDragonEgg();
                case 400004:
                    return new CardDragonkinSorcerer();
                case 400005:
                    return new CardDrakonidCrusher();
                case 400006:
                    return new CardEmperorThaurissan();
                case 400007:
                    return new CardGrimPatron();
                case 400008:
                    return new CardHungryDragon();
                case 400009:
                    return new CardMajordomoExecutus();
                case 400010:
                    return new CardNefarian();
                case 400011:
                    return new CardRendBlackhand();
                case 400012:
                    return new CardVolcanicDrake();
                case 401000:
                    return new CardDruidoftheFlame();
                case 401001:
                    return new CardVolcanicLumberer();
                case 402000:
                    return new CardCoreRager();
                case 402001:
                    return new CardQuickShot();
                case 403000:
                    return new CardDragonsBreath();
                case 403001:
                    return new CardFlamewaker();
                case 404000:
                    return new CardDragonConsort();
                case 404001:
                    return new CardSolemnVigil();
                case 405000:
                    return new CardResurrect();
                case 405001:
                    return new CardTwilightWhelp();
                case 406000:
                    return new CardDarkIronSkulker();
                case 406001:
                    return new CardGangUp();
                case 407000:
                    return new CardFireguardDestroyer();
                case 407001:
                    return new CardLavaShock();
                case 408000:
                    return new CardDemonwrath();
                case 408001:
                    return new CardImpGangBoss();
                case 409000:
                    return new CardAxeFlinger();
                case 409001:
                    return new CardRevenge();
                case 500000:
                    return new CardArgentHorserider();
                case 500001:
                    return new CardArgentWatchman();
                case 500002:
                    return new CardArmoredWarhorse();
                case 500003:
                    return new CardBolfRamshield();
                case 500004:
                    return new CardBoneguardLieutenant();
                case 500005:
                    return new CardCapturedJormungar();
                case 500006:
                    return new CardChillmaw();
                case 500007:
                    return new CardClockworkKnight();
                case 500008:
                    return new CardColiseumManager();
                case 500009:
                    return new CardCrowdFavorite();
                case 500010:
                    return new CardDragonhawkRider();
                case 500011:
                    return new CardEvilHeckler();
                case 500012:
                    return new CardEydisDarkbane();
                case 500013:
                    return new CardFencingCoach();
                case 500014:
                    return new CardFjolaLightbane();
                case 500015:
                    return new CardFlameJuggler();
                case 500016:
                    return new CardFrigidSnobold();
                case 500017:
                    return new CardFrostGiant();
                case 500018:
                    return new CardGadgetzanJouster();
                case 500019:
                    return new CardGarrisonCommander();
                case 500020:
                    return new CardGormoktheImpaler();
                case 500021:
                    return new CardGrandCrusader();
                case 500022:
                    return new CardIceRager();
                case 500023:
                    return new CardIcehowl();
                case 500024:
                    return new CardInjuredKvaldir();
                case 500025:
                    return new CardJusticarTrueheart();
                case 500026:
                    return new CardKodorider();
                case 500027:
                    return new CardKvaldirRaider();
                case 500028:
                    return new CardLanceBearer();
                case 500029:
                    return new CardLightsChampion();
                case 500030:
                    return new CardLowlySquire();
                case 500031:
                    return new CardMaidenoftheLake();
                case 500032:
                    return new CardMasterJouster();
                case 500033:
                    return new CardMasterofCeremonies();
                case 500034:
                    return new CardMogorsChampion();
                case 500035:
                    return new CardMuklasChampion();
                case 500036:
                    return new CardNexusChampionSaraad();
                case 500037:
                    return new CardNorthSeaKraken();
                case 500038:
                    return new CardPitFighter();
                case 500039:
                    return new CardRecruiter();
                case 500040:
                    return new CardRefreshmentVendor();
                case 500041:
                    return new CardSaboteur();
                case 500042:
                    return new CardSideshowSpelleater();
                case 500043:
                    return new CardSilentKnight();
                case 500044:
                    return new CardSilverHandRegent();
                case 500045:
                    return new CardSkycapnKragg();
                case 500046:
                    return new CardTheSkeletonKnight();
                case 500047:
                    return new CardTournamentAttendee();
                case 500048:
                    return new CardTournamentMedic();
                case 500049:
                    return new CardTwilightGuardian();
                case 501000:
                    return new CardAstralCommunion();
                case 501001:
                    return new CardAviana();
                case 501002:
                    return new CardDarnassusAspirant();
                case 501003:
                    return new CardDruidoftheSaber();
                case 501004:
                    return new CardKnightoftheWild();
                case 501005:
                    return new CardLivingRoots();
                case 501006:
                    return new CardMulch();
                case 501007:
                    return new CardSavageCombatant();
                case 501008:
                    return new CardWildwalker();
                case 502000:
                    return new CardAcidmaw();
                case 502001:
                    return new CardBallofSpiders();
                case 502002:
                    return new CardBearTrap();
                case 502003:
                    return new CardBraveArcher();
                case 502004:
                    return new CardDreadscale();
                case 502005:
                    return new CardKingsElekk();
                case 502006:
                    return new CardLockandLoad();
                case 502007:
                    return new CardPowershot();
                case 502008:
                    return new CardRamWrangler();
                case 502009:
                    return new CardStablemaster();
                case 503000:
                    return new CardArcaneBlast();
                case 503001:
                    return new CardColdarraDrake();
                case 503002:
                    return new CardDalaranAspirant();
                case 503003:
                    return new CardEffigy();
                case 503004:
                    return new CardFallenHero();
                case 503005:
                    return new CardFlameLance();
                case 503006:
                    return new CardPolymorphBoar();
                case 503007:
                    return new CardRhonin();
                case 503008:
                    return new CardSpellslinger();
                case 504000:
                    return new CardArgentLance();
                case 504001:
                    return new CardCompetitiveSpirit();
                case 504002:
                    return new CardEadricthePure();
                case 504003:
                    return new CardEntertheColiseum();
                case 504004:
                    return new CardMurlocKnight();
                case 504005:
                    return new CardMysteriousChallenger();
                case 504006:
                    return new CardSealofChampions();
                case 504007:
                    return new CardTuskarrJouster();
                case 504008:
                    return new CardWarhorseTrainer();
                case 505000:
                    return new CardConfessorPaletress();
                case 505001:
                    return new CardConfuse();
                case 505002:
                    return new CardConvert();
                case 505003:
                    return new CardFlashHeal();
                case 505004:
                    return new CardHolyChampion();
                case 505005:
                    return new CardPowerWordGlory();
                case 505006:
                    return new CardShadowfiend();
                case 505007:
                    return new CardSpawnofShadows();
                case 505008:
                    return new CardWyrmrestAgent();
                case 506000:
                    return new CardAnubarak();
                case 506001:
                    return new CardBeneaththeGrounds();
                case 506002:
                    return new CardBuccaneer();
                case 506003:
                    return new CardBurgle();
                case 506004:
                    return new CardCutpurse();
                case 506005:
                    return new CardPoisonedBlade();
                case 506006:
                    return new CardShadoPanCavalry();
                case 506007:
                    return new CardShadyDealer();
                case 506008:
                    return new CardUndercityValiant();
                case 507000:
                    return new CardAncestralKnowledge();
                case 507001:
                    return new CardChargedHammer();
                case 507002:
                    return new CardDraeneiTotemcarver();
                case 507003:
                    return new CardElementalDestruction();
                case 507004:
                    return new CardHealingWave();
                case 507005:
                    return new CardTheMistcaller();
                case 507006:
                    return new CardThunderBluffValiant();
                case 507007:
                    return new CardTotemGolem();
                case 507008:
                    return new CardTuskarrTotemic();
                case 508000:
                    return new CardDarkBargain();
                case 508001:
                    return new CardDemonfuse();
                case 508002:
                    return new CardDreadsteed();
                case 508003:
                    return new CardFearsomeDoomguard();
                case 508004:
                    return new CardFistofJaraxxus();
                case 508005:
                    return new CardTinyKnightofEvil();
                case 508006:
                    return new CardVoidCrusher();
                case 508007:
                    return new CardWilfredFizzlebang();
                case 508008:
                    return new CardWrathguard();
                case 509000:
                    return new CardAlexstraszasChampion();
                case 509001:
                    return new CardBash();
                case 509002:
                    return new CardBolster();
                case 509003:
                    return new CardKingsDefender();
                case 509004:
                    return new CardMagnataurAlpha();
                case 509005:
                    return new CardOrgrimmarAspirant();
                case 509006:
                    return new CardSeaReaver();
                case 509007:
                    return new CardSparringPartner();
                case 509008:
                    return new CardVarianWrynn();
                default:
                    return null;
            }
        }

        public static Card LoadCardFromString(String s)
        {
            
            return null;
        }
    }

    class Card : BroadCastObject
    {
        //attribute
        private int baseCost;

        //basic attribute
        private String cardText;
        private String cardName;
        private int cardId;
        private CardSet cSet;
        private CardClass cClass;
        private CardRarity cRarity;

        //control
        private int overload;
        private int realCost;
        //private CardTypes cardTypes;
        public int BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        public string CardText
        {
            get { return cardText; }
            set { cardText = value; }
        }

        public string CardName
        {
            get { return cardName; }
            set { cardName = value; }
        }

        public int CardId
        {
            get { return cardId; }
            set { cardId = value; }
        }


        public int RealCost
        {
            get { return realCost; }
            set { realCost = value; }
        }

        public CardSet CSet
        {
            get { return cSet; }
            set { cSet = value; }
        }

        public CardClass CClass
        {
            get { return cClass; }
            set { cClass = value; }
        }

        public CardRarity CRarity
        {
            get { return cRarity; }
            set { cRarity = value; }
        }


    }

    class WeaponCard : Card
    {
        private int baseDurability;
        private int baseAttack;

        public int BaseDurability
        {
            get { return baseDurability; }
            set { baseDurability = value; }
        }

        public int BaseAttack
        {
            get { return baseAttack; }
            set { baseAttack = value; }
        }
    }

    class SpellCard : Card
    {

    }

    class SecretCard : SpellCard
    {

    }

    class MinionCard : Card
    {
        private int baseHealth;
        private int baseAttack;
        private int realHealth;
        private int realAttack;

        public int BaseHealth
        {
            get { return baseHealth; }
            set { baseHealth = value; }
        }

        public int BaseAttack
        {
            get { return baseAttack; }
            set { baseAttack = value; }
        }

        public int RealHealth
        {
            get { return realHealth; }
            set { realHealth = value; }
        }

        public int RealAttack
        {
            get { return realAttack; }
            set { realAttack = value; }
        }
    }


    class CardAcidicSwampOoze : MinionCard
    {
        public CardAcidicSwampOoze()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 0;
            CardName = "Acidic Swamp Ooze";
            CardText = "Battlecry: Destroy your opponent's weapon.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardArchmage : MinionCard
    {
        public CardArchmage()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 1;
            CardName = "Archmage";
            CardText = "Spell Damage +1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardBloodfenRaptor : MinionCard
    {
        public CardBloodfenRaptor()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 2;
            CardName = "Bloodfen Raptor";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardBluegillWarrior : MinionCard
    {
        public CardBluegillWarrior()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 3;
            CardName = "Bluegill Warrior";
            CardText = "Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardBootyBayBodyguard : MinionCard
    {
        public CardBootyBayBodyguard()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 4;
            CardName = "Booty Bay Bodyguard";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardBoulderfistOgre : MinionCard
    {
        public CardBoulderfistOgre()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 5;
            CardName = "Boulderfist Ogre";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardChillwindYeti : MinionCard
    {
        public CardChillwindYeti()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 6;
            CardName = "Chillwind Yeti";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardCoreHound : MinionCard
    {
        public CardCoreHound()
        {
            BaseCost = 7;
            BaseAttack = 9;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 7;
            CardName = "Core Hound";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardDalaranMage : MinionCard
    {
        public CardDalaranMage()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 8;
            CardName = "Dalaran Mage";
            CardText = "Spell Damage +1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardDarkscaleHealer : MinionCard
    {
        public CardDarkscaleHealer()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 9;
            CardName = "Darkscale Healer";
            CardText = "Battlecry: Restore 2 Health to all friendly characters.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardDragonlingMechanic : MinionCard
    {
        public CardDragonlingMechanic()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 10;
            CardName = "Dragonling Mechanic";
            CardText = "Battlecry: Summon a 2/1 Mechanical Dragonling.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardElvenArcher : MinionCard
    {
        public CardElvenArcher()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 11;
            CardName = "Elven Archer";
            CardText = "Battlecry: Deal 1 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardFrostwolfGrunt : MinionCard
    {
        public CardFrostwolfGrunt()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 12;
            CardName = "Frostwolf Grunt";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardFrostwolfWarlord : MinionCard
    {
        public CardFrostwolfWarlord()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 13;
            CardName = "Frostwolf Warlord";
            CardText = "Battlecry: Gain +1/+1 for each other friendly minion on the battlefield.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardGnomishInventor : MinionCard
    {
        public CardGnomishInventor()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 14;
            CardName = "Gnomish Inventor";
            CardText = "Battlecry: Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardGoldshireFootman : MinionCard
    {
        public CardGoldshireFootman()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 15;
            CardName = "Goldshire Footman";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardGrimscaleOracle : MinionCard
    {
        public CardGrimscaleOracle()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 16;
            CardName = "Grimscale Oracle";
            CardText = "ALL other Murlocs have +1 Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardGurubashiBerserker : MinionCard
    {
        public CardGurubashiBerserker()
        {
            BaseCost = 5;
            BaseAttack = 2;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 17;
            CardName = "Gurubashi Berserker";
            CardText = "Whenever this minion takes damage, gain +3 Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardIronforgeRifleman : MinionCard
    {
        public CardIronforgeRifleman()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 18;
            CardName = "Ironforge Rifleman";
            CardText = "Battlecry: Deal 1 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardIronfurGrizzly : MinionCard
    {
        public CardIronfurGrizzly()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 19;
            CardName = "Ironfur Grizzly";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardKoboldGeomancer : MinionCard
    {
        public CardKoboldGeomancer()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 20;
            CardName = "Kobold Geomancer";
            CardText = "Spell Damage +1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardLordoftheArena : MinionCard
    {
        public CardLordoftheArena()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 21;
            CardName = "Lord of the Arena";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardMagmaRager : MinionCard
    {
        public CardMagmaRager()
        {
            BaseCost = 3;
            BaseAttack = 5;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 22;
            CardName = "Magma Rager";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardMurlocRaider : MinionCard
    {
        public CardMurlocRaider()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 23;
            CardName = "Murloc Raider";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardMurlocTidehunter : MinionCard
    {
        public CardMurlocTidehunter()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 24;
            CardName = "Murloc Tidehunter";
            CardText = "Battlecry: Summon a 1/1 Murloc Scout.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardNightblade : MinionCard
    {
        public CardNightblade()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 25;
            CardName = "Nightblade";
            CardText = "Battlecry: Deal 3 damage to the enemy hero.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardNoviceEngineer : MinionCard
    {
        public CardNoviceEngineer()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 26;
            CardName = "Novice Engineer";
            CardText = "Battlecry: Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardOasisSnapjaw : MinionCard
    {
        public CardOasisSnapjaw()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 27;
            CardName = "Oasis Snapjaw";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardOgreMagi : MinionCard
    {
        public CardOgreMagi()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 28;
            CardName = "Ogre Magi";
            CardText = "Spell Damage +1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardRaidLeader : MinionCard
    {
        public CardRaidLeader()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 29;
            CardName = "Raid Leader";
            CardText = "Your other minions have +1 Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardRazorfenHunter : MinionCard
    {
        public CardRazorfenHunter()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 30;
            CardName = "Razorfen Hunter";
            CardText = "Battlecry: Summon a 1/1 Boar.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardRecklessRocketeer : MinionCard
    {
        public CardRecklessRocketeer()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 31;
            CardName = "Reckless Rocketeer";
            CardText = "Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardRiverCrocolisk : MinionCard
    {
        public CardRiverCrocolisk()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 32;
            CardName = "River Crocolisk";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardSenjinShieldmasta : MinionCard
    {
        public CardSenjinShieldmasta()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 33;
            CardName = "Sen'jin Shieldmasta";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardShatteredSunCleric : MinionCard
    {
        public CardShatteredSunCleric()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 34;
            CardName = "Shattered Sun Cleric";
            CardText = "Battlecry: Give a friendly minion +1/+1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardSilverbackPatriarch : MinionCard
    {
        public CardSilverbackPatriarch()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 35;
            CardName = "Silverback Patriarch";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardStonetuskBoar : MinionCard
    {
        public CardStonetuskBoar()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 36;
            CardName = "Stonetusk Boar";
            CardText = "Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardStormpikeCommando : MinionCard
    {
        public CardStormpikeCommando()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 37;
            CardName = "Stormpike Commando";
            CardText = "Battlecry: Deal 2 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardStormwindChampion : MinionCard
    {
        public CardStormwindChampion()
        {
            BaseCost = 7;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 38;
            CardName = "Stormwind Champion";
            CardText = "Your other minions have +1/+1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardStormwindKnight : MinionCard
    {
        public CardStormwindKnight()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 39;
            CardName = "Stormwind Knight";
            CardText = "Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardVoodooDoctor : MinionCard
    {
        public CardVoodooDoctor()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 40;
            CardName = "Voodoo Doctor";
            CardText = "Battlecry: Restore 2 Health.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardWarGolem : MinionCard
    {
        public CardWarGolem()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 41;
            CardName = "War Golem";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardWolfrider : MinionCard
    {
        public CardWolfrider()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 42;
            CardName = "Wolfrider";
            CardText = "Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Free;
        }
    }

    class CardClaw : SpellCard
    {
        public CardClaw()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 1000;
            CardName = "Claw";
            CardText = "Give your hero +2 attack this turn and 2 Armor.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardHealingTouch : SpellCard
    {
        public CardHealingTouch()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 1001;
            CardName = "Healing Touch";
            CardText = "Restore 8 Health.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardInnervate : SpellCard
    {
        public CardInnervate()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 1002;
            CardName = "Innervate";
            CardText = "Gain 2 Mana Crystals this turn only.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardIronbarkProtector : MinionCard
    {
        public CardIronbarkProtector()
        {
            BaseCost = 8;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 1003;
            CardName = "Ironbark Protector";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardMarkoftheWild : SpellCard
    {
        public CardMarkoftheWild()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 1004;
            CardName = "Mark of the Wild";
            CardText = "Give a minion Taunt and +2/+2. (+2 Attack and +2 Health)";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardMoonfire : SpellCard
    {
        public CardMoonfire()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 1005;
            CardName = "Moonfire";
            CardText = "Deal 1 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardSavageRoar : SpellCard
    {
        public CardSavageRoar()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 1006;
            CardName = "Savage Roar";
            CardText = "Give your Characters +2 Attack this turn.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardStarfire : SpellCard
    {
        public CardStarfire()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 1007;
            CardName = "Starfire";
            CardText = "Deal 5 damage. Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardSwipe : SpellCard
    {
        public CardSwipe()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 1008;
            CardName = "Swipe";
            CardText = "Deal 4 damage to an enemy and 1 damage to all other enemies.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardWildGrowth : SpellCard
    {
        public CardWildGrowth()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 1009;
            CardName = "Wild Growth";
            CardText = "Gain an empty Mana Crystal.";
            CSet = CardSet.Basic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Free;
        }
    }

    class CardAnimalCompanion : SpellCard
    {
        public CardAnimalCompanion()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 2000;
            CardName = "Animal Companion";
            CardText = "Summon a random Beast companion.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardArcaneShot : SpellCard
    {
        public CardArcaneShot()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 2001;
            CardName = "Arcane Shot";
            CardText = "Deal 2 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardHoundmaster : MinionCard
    {
        public CardHoundmaster()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 2002;
            CardName = "Houndmaster";
            CardText = "Battlecry: Give a friendly Beast +2/+2 and Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardHuntersMark : SpellCard
    {
        public CardHuntersMark()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 2003;
            CardName = "Hunter's Mark";
            CardText = "Change a minion's Health to 1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardKillCommand : SpellCard
    {
        public CardKillCommand()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 2004;
            CardName = "Kill Command";
            CardText = "Deal 3 damage. If you have a Beast, deal 5 damage instead.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardMultiShot : SpellCard
    {
        public CardMultiShot()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 2005;
            CardName = "Multi-Shot";
            CardText = "Deal 3 damage to two random enemy minions.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardStarvingBuzzard : MinionCard
    {
        public CardStarvingBuzzard()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 2006;
            CardName = "Starving Buzzard";
            CardText = "Whenever you summon a Beast, draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardTimberWolf : MinionCard
    {
        public CardTimberWolf()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 2007;
            CardName = "Timber Wolf";
            CardText = "Your other Beasts have +1 Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardTracking : SpellCard
    {
        public CardTracking()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 2008;
            CardName = "Tracking";
            CardText = "Look at the top three cards of your deck. Draw one and discard the others.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardTundraRhino : MinionCard
    {
        public CardTundraRhino()
        {
            BaseCost = 5;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 2009;
            CardName = "Tundra Rhino";
            CardText = "Your Beasts have Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Free;
        }
    }

    class CardArcaneExplosion : SpellCard
    {
        public CardArcaneExplosion()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 3000;
            CardName = "Arcane Explosion";
            CardText = "Deal 1 damage to all enemy minions.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardArcaneIntellect : SpellCard
    {
        public CardArcaneIntellect()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 3001;
            CardName = "Arcane Intellect";
            CardText = "Draw 2 cards.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardArcaneMissiles : SpellCard
    {
        public CardArcaneMissiles()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 3002;
            CardName = "Arcane Missiles";
            CardText = "Deal 3 damage randomly split among enemy characters.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardFireball : SpellCard
    {
        public CardFireball()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 3003;
            CardName = "Fireball";
            CardText = "Deal 6 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardFlamestrike : SpellCard
    {
        public CardFlamestrike()
        {
            BaseCost = 7;
            RealCost = BaseCost;

            CardId = 3004;
            CardName = "Flamestrike";
            CardText = "Deal 4 damage to all enemy minions.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardFrostNova : SpellCard
    {
        public CardFrostNova()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 3005;
            CardName = "Frost Nova";
            CardText = "Freeze all enemy minions.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardFrostbolt : SpellCard
    {
        public CardFrostbolt()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 3006;
            CardName = "Frostbolt";
            CardText = "Deal 3 damage to a character and Freeze it.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardMirrorImage : SpellCard
    {
        public CardMirrorImage()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 3007;
            CardName = "Mirror Image";
            CardText = "Summon two 0/2 minions with Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardPolymorph : SpellCard
    {
        public CardPolymorph()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 3008;
            CardName = "Polymorph";
            CardText = "Transform a minion into a 1/1 sheep.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardWaterElemental : MinionCard
    {
        public CardWaterElemental()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 3009;
            CardName = "Water Elemental";
            CardText = "Freeze any character damaged by this minion.";
            CSet = CardSet.Basic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Free;
        }
    }

    class CardBlessingofKings : SpellCard
    {
        public CardBlessingofKings()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 4000;
            CardName = "Blessing of Kings";
            CardText = "Give a minion +4/+4 (+4 Attack / +4 Health).";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardBlessingofMight : SpellCard
    {
        public CardBlessingofMight()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 4001;
            CardName = "Blessing of Might";
            CardText = "Give a minion +3 Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardConsecration : SpellCard
    {
        public CardConsecration()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 4002;
            CardName = "Consecration";
            CardText = "Deal 2 damage to all enemies.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardGuardianofKings : MinionCard
    {
        public CardGuardianofKings()
        {
            BaseCost = 7;
            BaseAttack = 5;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 4003;
            CardName = "Guardian of Kings";
            CardText = "Battlecry: Restore 6 Health to your hero.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardHammerofWrath : SpellCard
    {
        public CardHammerofWrath()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 4004;
            CardName = "Hammer of Wrath";
            CardText = "Deal 3 damage. Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardHandofProtection : SpellCard
    {
        public CardHandofProtection()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 4005;
            CardName = "Hand of Protection";
            CardText = "Give a minion Divine Shield.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardHolyLight : SpellCard
    {
        public CardHolyLight()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 4006;
            CardName = "Holy Light";
            CardText = "Restore 6 Health.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardHumility : SpellCard
    {
        public CardHumility()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 4007;
            CardName = "Humility";
            CardText = "Change a minion's Attack to 1.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardLightsJustice : WeaponCard
    {
        public CardLightsJustice()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseDurability = 4;
            RealCost = BaseCost;

            CardId = 4008;
            CardName = "Light's Justice";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardTruesilverChampion : WeaponCard
    {
        public CardTruesilverChampion()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 4009;
            CardName = "Truesilver Champion";
            CardText = "Whenever your hero attacks, restore 2 health to it.";
            CSet = CardSet.Basic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Free;
        }
    }

    class CardDivineSpirit : SpellCard
    {
        public CardDivineSpirit()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 5000;
            CardName = "Divine Spirit";
            CardText = "Double a minion's Health.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardHolyNova : SpellCard
    {
        public CardHolyNova()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 5001;
            CardName = "Holy Nova";
            CardText = "Deal 2 damage to all enemies. Restore 2 Health to all friendly characters.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardHolySmite : SpellCard
    {
        public CardHolySmite()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 5002;
            CardName = "Holy Smite";
            CardText = "Deal 2 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardMindBlast : SpellCard
    {
        public CardMindBlast()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 5003;
            CardName = "Mind Blast";
            CardText = "Deal 5 damage to the enemy hero.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardMindControl : SpellCard
    {
        public CardMindControl()
        {
            BaseCost = 10;
            RealCost = BaseCost;

            CardId = 5004;
            CardName = "Mind Control";
            CardText = "Take control of an enemy minion.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardMindVision : SpellCard
    {
        public CardMindVision()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 5005;
            CardName = "Mind Vision";
            CardText = "Put a copy of a random card in your opponent's hand into your hand.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardNorthshireCleric : MinionCard
    {
        public CardNorthshireCleric()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 5006;
            CardName = "Northshire Cleric";
            CardText = "Whenever a minion is healed, draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardPowerWordShield : SpellCard
    {
        public CardPowerWordShield()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 5007;
            CardName = "Power Word: Shield";
            CardText = "Give a minion +2 Health. Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardShadowWordDeath : SpellCard
    {
        public CardShadowWordDeath()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 5008;
            CardName = "Shadow Word: Death";
            CardText = "Destroy a minion with an attack of 5 or more";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardShadowWordPain : SpellCard
    {
        public CardShadowWordPain()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 5009;
            CardName = "Shadow Word: Pain";
            CardText = "Destroy a minion with 3 or less Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Free;
        }
    }

    class CardAssassinate : SpellCard
    {
        public CardAssassinate()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 6000;
            CardName = "Assassinate";
            CardText = "Destroy an enemy minion.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardAssassinsBlade : WeaponCard
    {
        public CardAssassinsBlade()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseDurability = 4;
            RealCost = BaseCost;

            CardId = 6001;
            CardName = "Assassin's Blade";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardBackstab : SpellCard
    {
        public CardBackstab()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 6002;
            CardName = "Backstab";
            CardText = "Deal 2 damage to an undamaged minion.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardDeadlyPoison : SpellCard
    {
        public CardDeadlyPoison()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 6003;
            CardName = "Deadly Poison";
            CardText = "Give your weapon +2 Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardFanofKnives : SpellCard
    {
        public CardFanofKnives()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 6004;
            CardName = "Fan of Knives";
            CardText = "Deal 1 damage to all enemy minions. Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardSap : SpellCard
    {
        public CardSap()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 6005;
            CardName = "Sap";
            CardText = "Return an enemy minion to its owner's hand.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardShiv : SpellCard
    {
        public CardShiv()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 6006;
            CardName = "Shiv";
            CardText = "Deal 1 damage. Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardSinisterStrike : SpellCard
    {
        public CardSinisterStrike()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 6007;
            CardName = "Sinister Strike";
            CardText = "Deal 3 damage to the enemy hero.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardSprint : SpellCard
    {
        public CardSprint()
        {
            BaseCost = 7;
            RealCost = BaseCost;

            CardId = 6008;
            CardName = "Sprint";
            CardText = "Draw 4 cards.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardVanish : SpellCard
    {
        public CardVanish()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 6009;
            CardName = "Vanish";
            CardText = "Return all minions to their owner's hand.";
            CSet = CardSet.Basic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Free;
        }
    }

    class CardAncestralHealing : SpellCard
    {
        public CardAncestralHealing()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 7000;
            CardName = "Ancestral Healing";
            CardText = "Restore a minion to full health and give it Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardBloodlust : SpellCard
    {
        public CardBloodlust()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 7001;
            CardName = "Bloodlust";
            CardText = "Give your Minions +3 Attack this turn.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardFireElemental : MinionCard
    {
        public CardFireElemental()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 7002;
            CardName = "Fire Elemental";
            CardText = "Battlecry: Deal 3 damage.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardFlametongueTotem : MinionCard
    {
        public CardFlametongueTotem()
        {
            BaseCost = 2;
            BaseAttack = 0;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 7003;
            CardName = "Flametongue Totem";
            CardText = "Adjacent minions have +2 Attack.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardFrostShock : SpellCard
    {
        public CardFrostShock()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 7004;
            CardName = "Frost Shock";
            CardText = "Deal 1 damage to an enemy character and Freeze it.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardHex : SpellCard
    {
        public CardHex()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 7005;
            CardName = "Hex";
            CardText = "Transform a minion into a 0/1 frog with Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardRockbiterWeapon : SpellCard
    {
        public CardRockbiterWeapon()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 7006;
            CardName = "Rockbiter Weapon";
            CardText = "Give a friendly character +3 Attack this turn.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardTotemicMight : SpellCard
    {
        public CardTotemicMight()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 7007;
            CardName = "Totemic Might";
            CardText = "Give your Totems +2 Health.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardWindfury : SpellCard
    {
        public CardWindfury()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 7008;
            CardName = "Windfury";
            CardText = "Give a minion Windfury.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardWindspeaker : MinionCard
    {
        public CardWindspeaker()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 7009;
            CardName = "Windspeaker";
            CardText = "Battlecry: Give a friendly minion Windfury.";
            CSet = CardSet.Basic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Free;
        }
    }

    class CardCorruption : SpellCard
    {
        public CardCorruption()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 8000;
            CardName = "Corruption";
            CardText = "Choose an enemy minion. At the start of your turn, destroy it.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardDrainLife : SpellCard
    {
        public CardDrainLife()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 8001;
            CardName = "Drain Life";
            CardText = "Deal 2 damage. Restore 2 Health to your hero.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardDreadInfernal : MinionCard
    {
        public CardDreadInfernal()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 8002;
            CardName = "Dread Infernal";
            CardText = "Battlecry: Deal 1 damage to ALL other characters.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardHellfire : SpellCard
    {
        public CardHellfire()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 8003;
            CardName = "Hellfire";
            CardText = "Deal 3 damage to ALL characters.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardMortalCoil : SpellCard
    {
        public CardMortalCoil()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 8004;
            CardName = "Mortal Coil";
            CardText = "Deal 1 damage to a minion. If that kills it, draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardSacrificialPact : SpellCard
    {
        public CardSacrificialPact()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 8005;
            CardName = "Sacrificial Pact";
            CardText = "Destroy a Demon. Restore 5 Health to your hero.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardShadowBolt : SpellCard
    {
        public CardShadowBolt()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 8006;
            CardName = "Shadow Bolt";
            CardText = "Deal 4 damage to a minion.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardSoulfire : SpellCard
    {
        public CardSoulfire()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 8007;
            CardName = "Soulfire";
            CardText = "Deal 4 damage. Discard a random card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardSuccubus : MinionCard
    {
        public CardSuccubus()
        {
            BaseCost = 2;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 8008;
            CardName = "Succubus";
            CardText = "Battlecry: Discard a random card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardVoidwalker : MinionCard
    {
        public CardVoidwalker()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 8009;
            CardName = "Voidwalker";
            CardText = "Taunt.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Free;
        }
    }

    class CardArcaniteReaper : WeaponCard
    {
        public CardArcaniteReaper()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 9000;
            CardName = "Arcanite Reaper";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardCharge : SpellCard
    {
        public CardCharge()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 9001;
            CardName = "Charge";
            CardText = "Give a friendly minion +2 Attack and Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardCleave : SpellCard
    {
        public CardCleave()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 9002;
            CardName = "Cleave";
            CardText = "Deal 2 damage to two random enemy minions.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardExecute : SpellCard
    {
        public CardExecute()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 9003;
            CardName = "Execute";
            CardText = "Destroy a damaged enemy minion.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardFieryWarAxe : WeaponCard
    {
        public CardFieryWarAxe()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 9004;
            CardName = "Fiery War Axe";
            CardText = "";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardHeroicStrike : SpellCard
    {
        public CardHeroicStrike()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 9005;
            CardName = "Heroic Strike";
            CardText = "Give your hero +4 Attack this turn.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardKorKronElite : MinionCard
    {
        public CardKorKronElite()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 9006;
            CardName = "Kor'Kron Elite";
            CardText = "Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardShieldBlock : SpellCard
    {
        public CardShieldBlock()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 9007;
            CardName = "Shield Block";
            CardText = "Gain 5 Armor. Draw a card.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardWarsongCommander : MinionCard
    {
        public CardWarsongCommander()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 9008;
            CardName = "Warsong Commander";
            CardText = "Whenever you play a minion with 3 or less Attack, give it Charge.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardWhirlwind : SpellCard
    {
        public CardWhirlwind()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 9009;
            CardName = "Whirlwind";
            CardText = "Deal 1 damage to ALL minions.";
            CSet = CardSet.Basic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Free;
        }
    }

    class CardAbomination : MinionCard
    {
        public CardAbomination()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100000;
            CardName = "Abomination";
            CardText = "Taunt. Deathrattle: Deal 2 damage to ALL characters.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardAbusiveSergeant : MinionCard
    {
        public CardAbusiveSergeant()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100001;
            CardName = "Abusive Sergeant";
            CardText = "Battlecry: Give a minion +2 Attack until the end of turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardAcolyteofPain : MinionCard
    {
        public CardAcolyteofPain()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100002;
            CardName = "Acolyte of Pain";
            CardText = "Whenever this minion takes damage, draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardAlarmoBot : MinionCard
    {
        public CardAlarmoBot()
        {
            BaseCost = 3;
            BaseAttack = 0;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100003;
            CardName = "Alarm-o-Bot";
            CardText = "At the start of your turn, swap this minion with a random one in your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardAlexstrasza : MinionCard
    {
        public CardAlexstrasza()
        {
            BaseCost = 9;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100004;
            CardName = "Alexstrasza";
            CardText = "Battlecry: Set a hero's remaining Health to 15.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardAmaniBerserker : MinionCard
    {
        public CardAmaniBerserker()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100005;
            CardName = "Amani Berserker";
            CardText = "Enrage: +3 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardAncientBrewmaster : MinionCard
    {
        public CardAncientBrewmaster()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100006;
            CardName = "Ancient Brewmaster";
            CardText = "Battlecry: Return a friendly minion from the battlefield to your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardAncientMage : MinionCard
    {
        public CardAncientMage()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100007;
            CardName = "Ancient Mage";
            CardText = "Battlecry: Give adjacent minions Spell Damage +1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardAncientWatcher : MinionCard
    {
        public CardAncientWatcher()
        {
            BaseCost = 2;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100008;
            CardName = "Ancient Watcher";
            CardText = "Can't Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardAngryChicken : MinionCard
    {
        public CardAngryChicken()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100009;
            CardName = "Angry Chicken";
            CardText = "Enrage: +5 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardArcaneGolem : MinionCard
    {
        public CardArcaneGolem()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100010;
            CardName = "Arcane Golem";
            CardText = "Charge. Battlecry: Give your opponent a Mana Crystal.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardArgentCommander : MinionCard
    {
        public CardArgentCommander()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100011;
            CardName = "Argent Commander";
            CardText = "Charge. Divine Shield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardArgentSquire : MinionCard
    {
        public CardArgentSquire()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100012;
            CardName = "Argent Squire";
            CardText = "Divine Shield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardAzureDrake : MinionCard
    {
        public CardAzureDrake()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100013;
            CardName = "Azure Drake";
            CardText = "Spell Damage +1. Battlecry: Draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBaronGeddon : MinionCard
    {
        public CardBaronGeddon()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100014;
            CardName = "Baron Geddon";
            CardText = "At the end of your turn, deal 2 damage to ALL other characters.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardBigGameHunter : MinionCard
    {
        public CardBigGameHunter()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100015;
            CardName = "Big Game Hunter";
            CardText = "Battlecry: Destroy a minion with an Attack of 7 or more.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardBloodKnight : MinionCard
    {
        public CardBloodKnight()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100016;
            CardName = "Blood Knight";
            CardText = "Battlecry: All minions lose Divine Shield. Gain +3/+3 for each Shield lost.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardBloodmageThalnos : MinionCard
    {
        public CardBloodmageThalnos()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100017;
            CardName = "Bloodmage Thalnos";
            CardText = "Spell Damage +1. Deathrattle: Draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardBloodsailCorsair : MinionCard
    {
        public CardBloodsailCorsair()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100018;
            CardName = "Bloodsail Corsair";
            CardText = "Battlecry: Remove 1 Durability from your opponent's weapon.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBloodsailRaider : MinionCard
    {
        public CardBloodsailRaider()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100019;
            CardName = "Bloodsail Raider";
            CardText = "Battlecry: Gain Attack equal to the Attack of your weapon.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardCairneBloodhoof : MinionCard
    {
        public CardCairneBloodhoof()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100020;
            CardName = "Cairne Bloodhoof";
            CardText = "Deathrattle: Summon a 4/5 Baine Bloodhoof.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardCaptainGreenskin : MinionCard
    {
        public CardCaptainGreenskin()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100021;
            CardName = "Captain Greenskin";
            CardText = "Battlecry: Give your weapon +1/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardCaptainsParrot : MinionCard
    {
        public CardCaptainsParrot()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100022;
            CardName = "Captain's Parrot";
            CardText = "Battlecry: Put a random Pirate from your deck into your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardColdlightOracle : MinionCard
    {
        public CardColdlightOracle()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100023;
            CardName = "Coldlight Oracle";
            CardText = "Battlecry: Each player draws 2 cards.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardColdlightSeer : MinionCard
    {
        public CardColdlightSeer()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100024;
            CardName = "Coldlight Seer";
            CardText = "Battlecry: Give ALL other Murlocs +2 Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCrazedAlchemist : MinionCard
    {
        public CardCrazedAlchemist()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100025;
            CardName = "Crazed Alchemist";
            CardText = "Battlecry: Swap the Attack and Health of a minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCultMaster : MinionCard
    {
        public CardCultMaster()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100026;
            CardName = "Cult Master";
            CardText = "Whenever one of your other minions dies, draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardDarkIronDwarf : MinionCard
    {
        public CardDarkIronDwarf()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100027;
            CardName = "Dark Iron Dwarf";
            CardText = "Battlecry: Give a minion +2 Attack until the end of turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardDeathwing : MinionCard
    {
        public CardDeathwing()
        {
            BaseCost = 10;
            BaseAttack = 12;
            BaseHealth = 12;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100028;
            CardName = "Deathwing";
            CardText = "Battlecry: Destroy all other minions and discard your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardDefenderofArgus : MinionCard
    {
        public CardDefenderofArgus()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100029;
            CardName = "Defender of Argus";
            CardText = "Battlecry: Give adjacent minions +1/+1 and Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardDemolisher : MinionCard
    {
        public CardDemolisher()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100030;
            CardName = "Demolisher";
            CardText = "At the start of your turn, deal 2 damage to a random enemy.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardDireWolfAlpha : MinionCard
    {
        public CardDireWolfAlpha()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100031;
            CardName = "Dire Wolf Alpha";
            CardText = "Adjacent minions have +1 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardDoomsayer : MinionCard
    {
        public CardDoomsayer()
        {
            BaseCost = 2;
            BaseAttack = 0;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100032;
            CardName = "Doomsayer";
            CardText = "At the start of your turn, destroy ALL minions.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDreadCorsair : MinionCard
    {
        public CardDreadCorsair()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100033;
            CardName = "Dread Corsair";
            CardText = "Taunt. Costs (1) less per Attack of your weapon.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardEarthenRingFarseer : MinionCard
    {
        public CardEarthenRingFarseer()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100034;
            CardName = "Earthen Ring Farseer";
            CardText = "Battlecry: Restore 3 Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardEmperorCobra : MinionCard
    {
        public CardEmperorCobra()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100035;
            CardName = "Emperor Cobra";
            CardText = "Destroy any minion damaged by this minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFacelessManipulator : MinionCard
    {
        public CardFacelessManipulator()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100036;
            CardName = "Faceless Manipulator";
            CardText = "Battlecry: Choose a minion and become a copy of it.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardFaerieDragon : MinionCard
    {
        public CardFaerieDragon()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100037;
            CardName = "Faerie Dragon";
            CardText = "Can't be targeted by Spells or Hero Powers.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardFenCreeper : MinionCard
    {
        public CardFenCreeper()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100038;
            CardName = "Fen Creeper";
            CardText = "Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardFlesheatingGhoul : MinionCard
    {
        public CardFlesheatingGhoul()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100039;
            CardName = "Flesheating Ghoul";
            CardText = "Whenever a minion dies, gain +1 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardFrostElemental : MinionCard
    {
        public CardFrostElemental()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100040;
            CardName = "Frost Elemental";
            CardText = "Battlecry: Freeze a character.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardGadgetzanAuctioneer : MinionCard
    {
        public CardGadgetzanAuctioneer()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100041;
            CardName = "Gadgetzan Auctioneer";
            CardText = "Whenever you cast a spell, draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardGruul : MinionCard
    {
        public CardGruul()
        {
            BaseCost = 8;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100042;
            CardName = "Gruul";
            CardText = "At the end of each turn, gain +1/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardHarrisonJones : MinionCard
    {
        public CardHarrisonJones()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100043;
            CardName = "Harrison Jones";
            CardText = "Battlecry: Destroy your opponent's weapon and draw cards equal to its Durability.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardHarvestGolem : MinionCard
    {
        public CardHarvestGolem()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100044;
            CardName = "Harvest Golem";
            CardText = "Deathrattle: Summon a 2/1 Damaged Golem.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardHogger : MinionCard
    {
        public CardHogger()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100045;
            CardName = "Hogger";
            CardText = "At the end of your turn, summon a 2/2 Gnoll with Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardHungryCrab : MinionCard
    {
        public CardHungryCrab()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100046;
            CardName = "Hungry Crab";
            CardText = "Battlecry: Destroy a Murloc and gain +2/+2.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardIllidanStormrage : MinionCard
    {
        public CardIllidanStormrage()
        {
            BaseCost = 6;
            BaseAttack = 7;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100047;
            CardName = "Illidan Stormrage";
            CardText = "Whenever you play a card, summon a 2/1 Flame of Azzinoth.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardImpMaster : MinionCard
    {
        public CardImpMaster()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100048;
            CardName = "Imp Master";
            CardText = "At the end of your turn, deal 1 damage to this minion and summon a 1/1 Imp.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardInjuredBlademaster : MinionCard
    {
        public CardInjuredBlademaster()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100049;
            CardName = "Injured Blademaster";
            CardText = "Battlecry: Deal 4 damage to HIMSELF.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardIronbeakOwl : MinionCard
    {
        public CardIronbeakOwl()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100050;
            CardName = "Ironbeak Owl";
            CardText = "Battlecry: Silence a minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardJunglePanther : MinionCard
    {
        public CardJunglePanther()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100051;
            CardName = "Jungle Panther";
            CardText = "Stealth.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardKingMukla : MinionCard
    {
        public CardKingMukla()
        {
            BaseCost = 3;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100052;
            CardName = "King Mukla";
            CardText = "Battlecry: Give your opponent 2 Bananas.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardKnifeJuggler : MinionCard
    {
        public CardKnifeJuggler()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100053;
            CardName = "Knife Juggler";
            CardText = "After you summon a minion, deal 1 damage to a random enemy.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLeeroyJenkins : MinionCard
    {
        public CardLeeroyJenkins()
        {
            BaseCost = 5;
            BaseAttack = 6;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100054;
            CardName = "Leeroy Jenkins";
            CardText = "Charge. Battlecry: Summon two 1/1 Whelps for your opponent.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardLeperGnome : MinionCard
    {
        public CardLeperGnome()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100055;
            CardName = "Leper Gnome";
            CardText = "Deathrattle: Deal 2 damage to the enemy hero.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardLightwarden : MinionCard
    {
        public CardLightwarden()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100056;
            CardName = "Lightwarden";
            CardText = "Whenever a character is healed, gain +2 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLootHoarder : MinionCard
    {
        public CardLootHoarder()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100057;
            CardName = "Loot Hoarder";
            CardText = "Deathrattle: Draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardLorewalkerCho : MinionCard
    {
        public CardLorewalkerCho()
        {
            BaseCost = 2;
            BaseAttack = 0;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100058;
            CardName = "Lorewalker Cho";
            CardText = "Whenever a player casts a spell, put a copy into the other player's hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMadBomber : MinionCard
    {
        public CardMadBomber()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100059;
            CardName = "Mad Bomber";
            CardText = "Battlecry: Deal 3 damage randomly split between ALL other characters.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMalygos : MinionCard
    {
        public CardMalygos()
        {
            BaseCost = 9;
            BaseAttack = 4;
            BaseHealth = 12;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100060;
            CardName = "Malygos";
            CardText = "Spell Damage +5.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardManaAddict : MinionCard
    {
        public CardManaAddict()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100061;
            CardName = "Mana Addict";
            CardText = "Whenever you cast a spell, gain +2 Attack this turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardManaWraith : MinionCard
    {
        public CardManaWraith()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100062;
            CardName = "Mana Wraith";
            CardText = "ALL minions cost (1) more.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMasterSwordsmith : MinionCard
    {
        public CardMasterSwordsmith()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100063;
            CardName = "Master Swordsmith";
            CardText = "At the end of your turn, give another random friendly minion +1 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMillhouseManastorm : MinionCard
    {
        public CardMillhouseManastorm()
        {
            BaseCost = 2;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100064;
            CardName = "Millhouse Manastorm";
            CardText = "Battlecry: Enemy spells cost (0) next turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMindControlTech : MinionCard
    {
        public CardMindControlTech()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100065;
            CardName = "Mind Control Tech";
            CardText = "Battlecry: If your opponent has 4 or more minions, take control of one at random.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMogushanWarden : MinionCard
    {
        public CardMogushanWarden()
        {
            BaseCost = 4;
            BaseAttack = 1;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100066;
            CardName = "Mogu'shan Warden";
            CardText = "Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMoltenGiant : MinionCard
    {
        public CardMoltenGiant()
        {
            BaseCost = 20;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100067;
            CardName = "Molten Giant";
            CardText = "Costs (1) less for each damage your hero has taken.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMountainGiant : MinionCard
    {
        public CardMountainGiant()
        {
            BaseCost = 12;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100068;
            CardName = "Mountain Giant";
            CardText = "Costs (1) less for each other card in your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMurlocTidecaller : MinionCard
    {
        public CardMurlocTidecaller()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100069;
            CardName = "Murloc Tidecaller";
            CardText = "Whenever a Murloc is summoned, gain +1 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMurlocWarleader : MinionCard
    {
        public CardMurlocWarleader()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100070;
            CardName = "Murloc Warleader";
            CardText = "ALL other Murlocs have +2/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardNatPagle : MinionCard
    {
        public CardNatPagle()
        {
            BaseCost = 2;
            BaseAttack = 0;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100071;
            CardName = "Nat Pagle";
            CardText = "At the start of your turn, you have a 50% chance to draw an extra card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardNozdormu : MinionCard
    {
        public CardNozdormu()
        {
            BaseCost = 9;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100072;
            CardName = "Nozdormu";
            CardText = "Players only have 15 seconds to take their turns.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardOldMurkEye : MinionCard
    {
        public CardOldMurkEye()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100073;
            CardName = "Old Murk-Eye";
            CardText = "Charge. Has +1 Attack for each other Murloc on the battlefield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardOnyxia : MinionCard
    {
        public CardOnyxia()
        {
            BaseCost = 9;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100074;
            CardName = "Onyxia";
            CardText = "Battlecry: Summon 1/1 Whelps until your side of the battlefield is full.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardPintSizedSummoner : MinionCard
    {
        public CardPintSizedSummoner()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100075;
            CardName = "Pint-Sized Summoner";
            CardText = "The first minion you play each turn costs (1) less.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardPriestessofElune : MinionCard
    {
        public CardPriestessofElune()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100076;
            CardName = "Priestess of Elune";
            CardText = "Battlecry: Restore 4 Health to your hero.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardQuestingAdventurer : MinionCard
    {
        public CardQuestingAdventurer()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100077;
            CardName = "Questing Adventurer";
            CardText = "Whenever you play a card, gain +1/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardRagingWorgen : MinionCard
    {
        public CardRagingWorgen()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100078;
            CardName = "Raging Worgen";
            CardText = "Enrage: Windfury and +1 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardRagnarostheFirelord : MinionCard
    {
        public CardRagnarostheFirelord()
        {
            BaseCost = 8;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100079;
            CardName = "Ragnaros the Firelord";
            CardText = "Can't Attack. At the end of your turn, deal 8 damage to a random enemy.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardRavenholdtAssassin : MinionCard
    {
        public CardRavenholdtAssassin()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100080;
            CardName = "Ravenholdt Assassin";
            CardText = "Stealth.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardScarletCrusader : MinionCard
    {
        public CardScarletCrusader()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100081;
            CardName = "Scarlet Crusader";
            CardText = "Divine Shield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSeaGiant : MinionCard
    {
        public CardSeaGiant()
        {
            BaseCost = 10;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100082;
            CardName = "Sea Giant";
            CardText = "Costs (1) less for each other minion on the battlefield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSecretkeeper : MinionCard
    {
        public CardSecretkeeper()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100083;
            CardName = "Secretkeeper";
            CardText = "Whenever a Secret is played, gain +1/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardShieldbearer : MinionCard
    {
        public CardShieldbearer()
        {
            BaseCost = 1;
            BaseAttack = 0;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100084;
            CardName = "Shieldbearer";
            CardText = "Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSilverHandKnight : MinionCard
    {
        public CardSilverHandKnight()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100085;
            CardName = "Silver Hand Knight";
            CardText = "Battlecry: Summon a 2/2 Squire.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSilvermoonGuardian : MinionCard
    {
        public CardSilvermoonGuardian()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100086;
            CardName = "Silvermoon Guardian";
            CardText = "Divine Shield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSouthseaCaptain : MinionCard
    {
        public CardSouthseaCaptain()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100087;
            CardName = "Southsea Captain";
            CardText = "Your other Pirates have +1/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSouthseaDeckhand : MinionCard
    {
        public CardSouthseaDeckhand()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100088;
            CardName = "Southsea Deckhand";
            CardText = "Has Charge while you have a weapon equipped.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSpellbreaker : MinionCard
    {
        public CardSpellbreaker()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100089;
            CardName = "Spellbreaker";
            CardText = "Battlecry: Silence a minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSpitefulSmith : MinionCard
    {
        public CardSpitefulSmith()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100090;
            CardName = "Spiteful Smith";
            CardText = "Enrage: Your Weapon has +2 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardStampedingKodo : MinionCard
    {
        public CardStampedingKodo()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100091;
            CardName = "Stampeding Kodo";
            CardText = "Battlecry: Destroy a random enemy minion with 2 or less Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardStranglethornTiger : MinionCard
    {
        public CardStranglethornTiger()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100092;
            CardName = "Stranglethorn Tiger";
            CardText = "Stealth.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSunfuryProtector : MinionCard
    {
        public CardSunfuryProtector()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100093;
            CardName = "Sunfury Protector";
            CardText = "Battlecry: Give adjacent minions Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSunwalker : MinionCard
    {
        public CardSunwalker()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100094;
            CardName = "Sunwalker";
            CardText = "Taunt. Divine Shield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSylvanasWindrunner : MinionCard
    {
        public CardSylvanasWindrunner()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100095;
            CardName = "Sylvanas Windrunner";
            CardText = "Deathrattle: Take control of a random enemy minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardTaurenWarrior : MinionCard
    {
        public CardTaurenWarrior()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100096;
            CardName = "Tauren Warrior";
            CardText = "Taunt. Enrage: +3 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardTheBeast : MinionCard
    {
        public CardTheBeast()
        {
            BaseCost = 6;
            BaseAttack = 9;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100097;
            CardName = "The Beast";
            CardText = "Deathrattle: Summon a 3/3 Finkle Einhorn for your opponent.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardTheBlackKnight : MinionCard
    {
        public CardTheBlackKnight()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100098;
            CardName = "The Black Knight";
            CardText = "Battlecry: Destroy a minion with Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardThrallmarFarseer : MinionCard
    {
        public CardThrallmarFarseer()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100099;
            CardName = "Thrallmar Farseer";
            CardText = "Windfury.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardTinkmasterOverspark : MinionCard
    {
        public CardTinkmasterOverspark()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100100;
            CardName = "Tinkmaster Overspark";
            CardText = "Battlecry: Transform another random minion into a 5/5 Devilsaur or a 1/1 Squirrel.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardTwilightDrake : MinionCard
    {
        public CardTwilightDrake()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100101;
            CardName = "Twilight Drake";
            CardText = "Battlecry: Gain +1 Health for each card in your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardVentureCoMercenary : MinionCard
    {
        public CardVentureCoMercenary()
        {
            BaseCost = 5;
            BaseAttack = 7;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100102;
            CardName = "Venture Co. Mercenary";
            CardText = "Your minions cost (3) more.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardVioletTeacher : MinionCard
    {
        public CardVioletTeacher()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100103;
            CardName = "Violet Teacher";
            CardText = "Whenever you cast a spell, summon a 1/1 Violet Apprentice.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWildPyromancer : MinionCard
    {
        public CardWildPyromancer()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100104;
            CardName = "Wild Pyromancer";
            CardText = "After you cast a spell, deal 1 damage to ALL minions.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWindfuryHarpy : MinionCard
    {
        public CardWindfuryHarpy()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100105;
            CardName = "Windfury Harpy";
            CardText = "Windfury.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardWisp : MinionCard
    {
        public CardWisp()
        {
            BaseCost = 0;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100106;
            CardName = "Wisp";
            CardText = "";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardWorgenInfiltrator : MinionCard
    {
        public CardWorgenInfiltrator()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100107;
            CardName = "Worgen Infiltrator";
            CardText = "Stealth.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardYoungDragonhawk : MinionCard
    {
        public CardYoungDragonhawk()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100108;
            CardName = "Young Dragonhawk";
            CardText = "Windfury.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardYoungPriestess : MinionCard
    {
        public CardYoungPriestess()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100109;
            CardName = "Young Priestess";
            CardText = "At the end of your turn, give another random friendly minion +1 Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardYouthfulBrewmaster : MinionCard
    {
        public CardYouthfulBrewmaster()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100110;
            CardName = "Youthful Brewmaster";
            CardText = "Battlecry: Return a friendly minion from the battlefield to your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardYsera : MinionCard
    {
        public CardYsera()
        {
            BaseCost = 9;
            BaseAttack = 4;
            BaseHealth = 12;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 100111;
            CardName = "Ysera";
            CardText = "At the end of your turn, draw a Dream Card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardAncientofLore : MinionCard
    {
        public CardAncientofLore()
        {
            BaseCost = 7;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 101000;
            CardName = "Ancient of Lore";
            CardText = "Choose One - Draw 2 cards; or Restore 5 Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Epic;
        }
    }

    class CardAncientofWar : MinionCard
    {
        public CardAncientofWar()
        {
            BaseCost = 7;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 101001;
            CardName = "Ancient of War";
            CardText = "Choose One - +5 Attack; or +5 Health and Taunt";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Epic;
        }
    }

    class CardBite : SpellCard
    {
        public CardBite()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 101002;
            CardName = "Bite";
            CardText = "Give your hero +4 Attack this turn and 4 Armor.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCenarius : MinionCard
    {
        public CardCenarius()
        {
            BaseCost = 9;
            BaseAttack = 5;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 101003;
            CardName = "Cenarius";
            CardText = "Choose One - Give your other minions +2/+2; or Summon two 2/2 Treants with Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardDruidoftheClaw : MinionCard
    {
        public CardDruidoftheClaw()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 101004;
            CardName = "Druid of the Claw";
            CardText = "Choose One - Charge; or +2 Health and Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardForceofNature : SpellCard
    {
        public CardForceofNature()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 101005;
            CardName = "Force of Nature";
            CardText = "Summon three 2/2 treants with Charge that die at the end of the turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Epic;
        }
    }

    class CardKeeperoftheGrove : MinionCard
    {
        public CardKeeperoftheGrove()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 101006;
            CardName = "Keeper of the Grove";
            CardText = "Choose One - Deal 2 damage; or Silence a minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMarkofNature : SpellCard
    {
        public CardMarkofNature()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 101007;
            CardName = "Mark of Nature";
            CardText = "Choose One - Give a minion +4 Attack; or +4 Health and Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardNaturalize : SpellCard
    {
        public CardNaturalize()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 101008;
            CardName = "Naturalize";
            CardText = "Destroy a minion. Your opponent draws 2 cards.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardNourish : SpellCard
    {
        public CardNourish()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 101009;
            CardName = "Nourish";
            CardText = "Choose One - Gain 2 Mana Crystals; or draw 3 cards.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardPoweroftheWild : SpellCard
    {
        public CardPoweroftheWild()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 101010;
            CardName = "Power of the Wild";
            CardText = "Choose One - Give your minions +1/+1; or summon a 3/2 Panther.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardSavagery : SpellCard
    {
        public CardSavagery()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 101011;
            CardName = "Savagery";
            CardText = "Deal damage equal to your hero's attack to a minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSouloftheForest : SpellCard
    {
        public CardSouloftheForest()
	{
		BaseCost = 4;
		RealCost = BaseCost;

		CardId = 101012;
		CardName = "Soul of the Forest";
		CardText = "Give your minions \"Deathrattle: Summon a 2/2 Treant.\"";
		CSet = CardSet.Classic;
		CClass = CardClass.Druid;
		CRarity = CardRarity.Common;
	}
    }

    class CardStarfall : SpellCard
    {
        public CardStarfall()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 101013;
            CardName = "Starfall";
            CardText = "Choose One - Deal 5 damage to a minion; or 2 damage to all enemy minions.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWrath : SpellCard
    {
        public CardWrath()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 101014;
            CardName = "Wrath";
            CardText = "Choose One - Deal 3 damage to a minion; or 1 damage and draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardBestialWrath : SpellCard
    {
        public CardBestialWrath()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 102000;
            CardName = "Bestial Wrath";
            CardText = "Give a Beast +2 Attack and Immune this turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDeadlyShot : SpellCard
    {
        public CardDeadlyShot()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 102001;
            CardName = "Deadly Shot";
            CardText = "Destroy a random enemy minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardEaglehornBow : WeaponCard
    {
        public CardEaglehornBow()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 102002;
            CardName = "Eaglehorn Bow";
            CardText = "Whenever a friendly Secret is revealed, gain +1 durability.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardExplosiveShot : SpellCard
    {
        public CardExplosiveShot()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 102003;
            CardName = "Explosive Shot";
            CardText = "Deal 5 damage to a minion and 2 damage to adjacent ones.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardExplosiveTrap : SecretCard
    {
        public CardExplosiveTrap()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 102004;
            CardName = "Explosive Trap";
            CardText = "Secret: When your hero is attacked, deal 2 damage to all enemies.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardFlare : SpellCard
    {
        public CardFlare()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 102005;
            CardName = "Flare";
            CardText = "All minions lose Stealth. Destroy all enemy secrets. Draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFreezingTrap : SecretCard
    {
        public CardFreezingTrap()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 102006;
            CardName = "Freezing Trap";
            CardText = "Secret: When an enemy minion attacks, return it to its owner's hand and it costs (2) more.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardGladiatorsLongbow : WeaponCard
    {
        public CardGladiatorsLongbow()
        {
            BaseCost = 7;
            BaseAttack = 5;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 102007;
            CardName = "Gladiator's Longbow";
            CardText = "Your hero is Immune while attacking.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardKingKrush : MinionCard
    {
        public CardKingKrush()
        {
            BaseCost = 9;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 102008;
            CardName = "King Krush";
            CardText = "Charge.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMisdirection : SecretCard
    {
        public CardMisdirection()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 102009;
            CardName = "Misdirection";
            CardText = "Secret: When a character attacks your hero, instead he attacks another random character.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSavannahHighmane : MinionCard
    {
        public CardSavannahHighmane()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 102010;
            CardName = "Savannah Highmane";
            CardText = "Deathrattle: Summon two 2/2 Hyenas.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardScavengingHyena : MinionCard
    {
        public CardScavengingHyena()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 102011;
            CardName = "Scavenging Hyena";
            CardText = "Whenever a friendly Beast dies, gain +2/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardSnakeTrap : SecretCard
    {
        public CardSnakeTrap()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 102012;
            CardName = "Snake Trap";
            CardText = "Secret: When one of your minions is attacked, summon three 1/1 Snakes.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSnipe : SpellCard
    {
        public CardSnipe()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 102013;
            CardName = "Snipe";
            CardText = "Secret: When your opponent plays a minion, deal 4 damage to it.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardUnleashtheHounds : SpellCard
    {
        public CardUnleashtheHounds()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 102014;
            CardName = "Unleash the Hounds";
            CardText = "For each enemy minion, summon a 1/1 Hound with Charge.";
            CSet = CardSet.Classic;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardArchmageAntonidas : MinionCard
    {
        public CardArchmageAntonidas()
        {
            BaseCost = 7;
            BaseAttack = 5;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 103000;
            CardName = "Archmage Antonidas";
            CardText = "Whenever you cast a spell, put a 'Fireball' spell into your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardBlizzard : SpellCard
    {
        public CardBlizzard()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 103001;
            CardName = "Blizzard";
            CardText = "Deal 2 damage to all enemy minions and Freeze them.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardConeofCold : SpellCard
    {
        public CardConeofCold()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 103002;
            CardName = "Cone of Cold";
            CardText = "Freeze a minion and the minions next to it, and deal 1 damage to them.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardCounterspell : SecretCard
    {
        public CardCounterspell()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 103003;
            CardName = "Counterspell";
            CardText = "Secret: When your opponent casts a spell, Counter it.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardEtherealArcanist : MinionCard
    {
        public CardEtherealArcanist()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 103004;
            CardName = "Ethereal Arcanist";
            CardText = "If you control a Secret at the end of your turn, gain +2/+2.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardIceBarrier : SecretCard
    {
        public CardIceBarrier()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 103005;
            CardName = "Ice Barrier";
            CardText = "Secret: As soon as your hero is attacked, gain 8 armor.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardIceBlock : SecretCard
    {
        public CardIceBlock()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 103006;
            CardName = "Ice Block";
            CardText = "Secret: when your hero takes fatal damage, prevent it and become Immune this turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Epic;
        }
    }

    class CardIceLance : SpellCard
    {
        public CardIceLance()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 103007;
            CardName = "Ice Lance";
            CardText = "Freeze a character. If it was already Frozen, deal 4 damage instead.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardKirinTorMage : MinionCard
    {
        public CardKirinTorMage()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 103008;
            CardName = "Kirin Tor Mage";
            CardText = "Battlecry: The next Secret you play this turn costs (0).";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardManaWyrm : MinionCard
    {
        public CardManaWyrm()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 103009;
            CardName = "Mana Wyrm";
            CardText = "Whenever you cast a spell, gain +1 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardMirrorEntity : SecretCard
    {
        public CardMirrorEntity()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 103010;
            CardName = "Mirror Entity";
            CardText = "Secret: When your opponent plays a minion, summon a copy of it.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardPyroblast : SpellCard
    {
        public CardPyroblast()
        {
            BaseCost = 10;
            RealCost = BaseCost;

            CardId = 103011;
            CardName = "Pyroblast";
            CardText = "Deal 10 damage.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSorcerersApprentice : MinionCard
    {
        public CardSorcerersApprentice()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 103012;
            CardName = "Sorcerer's Apprentice";
            CardText = "Your spells cost (1) less.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardSpellbender : SecretCard
    {
        public CardSpellbender()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 103013;
            CardName = "Spellbender";
            CardText = "Secret: When an enemy casts a spell on a minion, summon a 1/3 as the new target.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Epic;
        }
    }

    class CardVaporize : SecretCard
    {
        public CardVaporize()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 103014;
            CardName = "Vaporize";
            CardText = "Secret: When a minion attacks your hero, destroy it.";
            CSet = CardSet.Classic;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardAldorPeacekeeper : MinionCard
    {
        public CardAldorPeacekeeper()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 104000;
            CardName = "Aldor Peacekeeper";
            CardText = "Battlecry: Change an enemy minion's attack to 1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardArgentProtector : MinionCard
    {
        public CardArgentProtector()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 104001;
            CardName = "Argent Protector";
            CardText = "Battlecry: Give a friendly minion Divine Shield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardAvengingWrath : SpellCard
    {
        public CardAvengingWrath()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 104002;
            CardName = "Avenging Wrath";
            CardText = "Deal 8 damage randomly split among enemy characters.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Epic;
        }
    }

    class CardBlessedChampion : SpellCard
    {
        public CardBlessedChampion()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 104003;
            CardName = "Blessed Champion";
            CardText = "Double a minion's Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBlessingofWisdom : SpellCard
    {
        public CardBlessingofWisdom()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 104004;
            CardName = "Blessing of Wisdom";
            CardText = "Choose a minion. Whenever it attacks, draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardDivineFavor : SpellCard
    {
        public CardDivineFavor()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 104005;
            CardName = "Divine Favor";
            CardText = "Draw cards until you have as many in hand as your opponent.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardEquality : SpellCard
    {
        public CardEquality()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 104006;
            CardName = "Equality";
            CardText = "Change the Health of ALL minions to 1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardEyeforanEye : SecretCard
    {
        public CardEyeforanEye()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 104007;
            CardName = "Eye for an Eye";
            CardText = "Secret: When your hero takes damage, deal that much damage to the enemy hero.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardHolyWrath : SpellCard
    {
        public CardHolyWrath()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 104008;
            CardName = "Holy Wrath";
            CardText = "Draw a card and deal damage equal to its cost.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLayonHands : SpellCard
    {
        public CardLayonHands()
        {
            BaseCost = 8;
            RealCost = BaseCost;

            CardId = 104009;
            CardName = "Lay on Hands";
            CardText = "Restore 8 Health. Draw 3 cards.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Epic;
        }
    }

    class CardNobleSacrifice : SecretCard
    {
        public CardNobleSacrifice()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 104010;
            CardName = "Noble Sacrifice";
            CardText = "Secret: When an enemy attacks, summon a 2/1 Defender as the new target.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardRedemption : SecretCard
    {
        public CardRedemption()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 104011;
            CardName = "Redemption";
            CardText = "Secret: When one of your minions dies, return it to life with 1 Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardRepentance : SecretCard
    {
        public CardRepentance()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 104012;
            CardName = "Repentance";
            CardText = "Secret: When your opponent plays a minion, reduce its Health to 1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardSwordofJustice : WeaponCard
    {
        public CardSwordofJustice()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseDurability = 5;
            RealCost = BaseCost;

            CardId = 104013;
            CardName = "Sword of Justice";
            CardText = "Whenever you summon a minion, give it +1/+1 and this loses 1 durability.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Epic;
        }
    }

    class CardTirionFordring : MinionCard
    {
        public CardTirionFordring()
        {
            BaseCost = 8;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 104014;
            CardName = "Tirion Fordring";
            CardText = "Divine Shield. Taunt. Deathrattle: Equip a 5/3 Ashbringer.";
            CSet = CardSet.Classic;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardAuchenaiSoulpriest : MinionCard
    {
        public CardAuchenaiSoulpriest()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 105000;
            CardName = "Auchenai Soulpriest";
            CardText = "Your cards and powers that restore Health now deal damage instead.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCabalShadowPriest : MinionCard
    {
        public CardCabalShadowPriest()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 105001;
            CardName = "Cabal Shadow Priest";
            CardText = "Battlecry: Take control of an enemy minion that has 2 or less Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Epic;
        }
    }

    class CardCircleofHealing : SpellCard
    {
        public CardCircleofHealing()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 105002;
            CardName = "Circle of Healing";
            CardText = "Restore 4 health to ALL minions.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardHolyFire : SpellCard
    {
        public CardHolyFire()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 105003;
            CardName = "Holy Fire";
            CardText = "Deal 5 damage. Restore 5 health to your hero.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardInnerFire : SpellCard
    {
        public CardInnerFire()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 105004;
            CardName = "Inner Fire";
            CardText = "Change a minion's Attack to be equal to its Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardLightspawn : MinionCard
    {
        public CardLightspawn()
        {
            BaseCost = 4;
            BaseAttack = 0;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 105005;
            CardName = "Lightspawn";
            CardText = "This minion's Attack is always equal to its Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardLightwell : MinionCard
    {
        public CardLightwell()
        {
            BaseCost = 2;
            BaseAttack = 0;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 105006;
            CardName = "Lightwell";
            CardText = "At the start of your turn, restore 3 Health to a damaged friendly character.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMassDispel : SpellCard
    {
        public CardMassDispel()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 105007;
            CardName = "Mass Dispel";
            CardText = "Silence all enemy minions. Draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMindgames : SpellCard
    {
        public CardMindgames()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 105008;
            CardName = "Mindgames";
            CardText = "Put a copy of a random minion from your opponent's deck into the battlefield.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Epic;
        }
    }

    class CardProphetVelen : MinionCard
    {
        public CardProphetVelen()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 105009;
            CardName = "Prophet Velen";
            CardText = "Double the damage and healing of your spells and hero power.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardShadowMadness : SpellCard
    {
        public CardShadowMadness()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 105010;
            CardName = "Shadow Madness";
            CardText = "Gain control of an enemy minion with 3 or less Attack until end of turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardShadowform : SpellCard
    {
        public CardShadowform()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 105011;
            CardName = "Shadowform";
            CardText = "Your Hero Power becomes 'Deal 2 damage'. If already in Shadowform: 3 damage.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSilence : SpellCard
    {
        public CardSilence()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 105012;
            CardName = "Silence";
            CardText = "Silence a minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardTempleEnforcer : MinionCard
    {
        public CardTempleEnforcer()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 105013;
            CardName = "Temple Enforcer";
            CardText = "Battlecry: Give a friendly minion +3 Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardThoughtsteal : SpellCard
    {
        public CardThoughtsteal()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 105014;
            CardName = "Thoughtsteal";
            CardText = "Copy 2 cards from your opponent's deck and put them into your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardBetrayal : SpellCard
    {
        public CardBetrayal()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 106000;
            CardName = "Betrayal";
            CardText = "Force an enemy minion to eal its damage to the minions next to it.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardBladeFlurry : SpellCard
    {
        public CardBladeFlurry()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 106001;
            CardName = "Blade Flurry";
            CardText = "Destroy your weapon and deal its damage to all enemies.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardColdBlood : SpellCard
    {
        public CardColdBlood()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 106002;
            CardName = "Cold Blood";
            CardText = "Give a minion +2 Attack. Combo: +4 Attack instead.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardConceal : SpellCard
    {
        public CardConceal()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 106003;
            CardName = "Conceal";
            CardText = "Give your minions Stealth until your next turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardDefiasRingleader : MinionCard
    {
        public CardDefiasRingleader()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 106004;
            CardName = "Defias Ringleader";
            CardText = "Combo: Summon a 2/1 Defias Bandit.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardEdwinVanCleef : MinionCard
    {
        public CardEdwinVanCleef()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 106005;
            CardName = "Edwin VanCleef";
            CardText = "Combo: Gain +2/+2 for each other card played earlier this turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardEviscerate : SpellCard
    {
        public CardEviscerate()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 106006;
            CardName = "Eviscerate";
            CardText = "Deal 2 damage. Combo: Deal 4 damage instead.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardHeadcrack : SpellCard
    {
        public CardHeadcrack()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 106007;
            CardName = "Headcrack";
            CardText = "Deal 2 damage to the enemy hero. Combo: Return this to your hand next turn.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardKidnapper : MinionCard
    {
        public CardKidnapper()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 106008;
            CardName = "Kidnapper";
            CardText = "Combo: Return a minion to its owner's hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMasterofDisguise : MinionCard
    {
        public CardMasterofDisguise()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 106009;
            CardName = "Master of Disguise";
            CardText = "Battlecry: Give a friendly minion Stealth.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardPatientAssassin : MinionCard
    {
        public CardPatientAssassin()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 106010;
            CardName = "Patient Assassin";
            CardText = "Stealth. Destroy any minion damaged by this minion.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Epic;
        }
    }

    class CardPerditionsBlade : WeaponCard
    {
        public CardPerditionsBlade()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 106011;
            CardName = "Perdition's Blade";
            CardText = "Battlecry: Deal 1 damage. Combo: Deal 2 instead.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardPreparation : SpellCard
    {
        public CardPreparation()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 106012;
            CardName = "Preparation";
            CardText = "The next spell you cast this turn costs (3) less.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Epic;
        }
    }

    class CardShadowstep : SpellCard
    {
        public CardShadowstep()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 106013;
            CardName = "Shadowstep";
            CardText = "Return a friendly minion to your hand. It costs (2) less.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardSI7Agent : MinionCard
    {
        public CardSI7Agent()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 106014;
            CardName = "SI:7 Agent";
            CardText = "Combo: Deal 2 damage.";
            CSet = CardSet.Classic;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardAlAkirtheWindlord : MinionCard
    {
        public CardAlAkirtheWindlord()
        {
            BaseCost = 8;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 107000;
            CardName = "Al'Akir the Windlord";
            CardText = "Windfury, Charge, Divine Shield, Taunt.";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardAncestralSpirit : SpellCard
    {
        public CardAncestralSpirit()
	{
		BaseCost = 2;
		RealCost = BaseCost;

		CardId = 107001;
		CardName = "Ancestral Spirit";
		CardText = "Give a minion \"Deathrattle: Resummon this minion.\"";
		CSet = CardSet.Classic;
		CClass = CardClass.Shaman;
		CRarity = CardRarity.Rare;
	}
    }

    class CardDoomhammer : WeaponCard
    {
        public CardDoomhammer()
        {
            BaseCost = 5;
            BaseAttack = 2;
            BaseDurability = 8;
            RealCost = BaseCost;

            CardId = 107002;
            CardName = "Doomhammer";
            CardText = "Windfury, Overload: (2)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDustDevil : MinionCard
    {
        public CardDustDevil()
        {
            BaseCost = 1;
            BaseAttack = 3;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 107003;
            CardName = "Dust Devil";
            CardText = "Windfury, Overload: (2)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardEarthElemental : MinionCard
    {
        public CardEarthElemental()
        {
            BaseCost = 5;
            BaseAttack = 7;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 107004;
            CardName = "Earth Elemental";
            CardText = "Taunt. Overload: (3)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Epic;
        }
    }

    class CardEarthShock : SpellCard
    {
        public CardEarthShock()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 107005;
            CardName = "Earth Shock";
            CardText = "Silence a minion, then deal 1 damage to it.";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardFarSight : SpellCard
    {
        public CardFarSight()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 107006;
            CardName = "Far Sight";
            CardText = "Draw a card. That card costs (3) less.";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Epic;
        }
    }

    class CardFeralSpirit : SpellCard
    {
        public CardFeralSpirit()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 107007;
            CardName = "Feral Spirit";
            CardText = "Summon two 2/3 Spirit Wolves with Taunt. Overload: (2)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardForkedLightning : SpellCard
    {
        public CardForkedLightning()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 107008;
            CardName = "Forked Lightning";
            CardText = "Deal 2 damage to 2 random enemy minions. Overload: (2)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardLavaBurst : SpellCard
    {
        public CardLavaBurst()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 107009;
            CardName = "Lava Burst";
            CardText = "Deal 5 damage. Overload: (2)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLightningBolt : SpellCard
    {
        public CardLightningBolt()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 107010;
            CardName = "Lightning Bolt";
            CardText = "Deal 3 damage. Overload: (1)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardLightningStorm : SpellCard
    {
        public CardLightningStorm()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 107011;
            CardName = "Lightning Storm";
            CardText = "Deal 2-3 damage to all enemy minions. Overload: (2)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardManaTideTotem : MinionCard
    {
        public CardManaTideTotem()
        {
            BaseCost = 3;
            BaseAttack = 0;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 107012;
            CardName = "Mana Tide Totem";
            CardText = "At the end of your turn, draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardStormforgedAxe : WeaponCard
    {
        public CardStormforgedAxe()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseDurability = 3;
            RealCost = BaseCost;

            CardId = 107013;
            CardName = "Stormforged Axe";
            CardText = "Overload: (1)";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardUnboundElemental : MinionCard
    {
        public CardUnboundElemental()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 107014;
            CardName = "Unbound Elemental";
            CardText = "Whenever you play a card with Overload, gain +1/+1.";
            CSet = CardSet.Classic;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardBaneofDoom : SpellCard
    {
        public CardBaneofDoom()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 108000;
            CardName = "Bane of Doom";
            CardText = "Deal 2 damage to a character. If that kills it, summon a random Demon.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Epic;
        }
    }

    class CardBloodImp : MinionCard
    {
        public CardBloodImp()
        {
            BaseCost = 1;
            BaseAttack = 0;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108001;
            CardName = "Blood Imp";
            CardText = "Stealth. At the end of your turn, give another random friendly minion +1 Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardDemonfire : SpellCard
    {
        public CardDemonfire()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 108002;
            CardName = "Demonfire";
            CardText = "Deal 2 damage to a minion. If it's a friendly Demon, give it +2/+2 instead.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardDoomguard : MinionCard
    {
        public CardDoomguard()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108003;
            CardName = "Doomguard";
            CardText = "Charge. Battlecry: Discard two random cards.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFelguard : MinionCard
    {
        public CardFelguard()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108004;
            CardName = "Felguard";
            CardText = "Taunt. Battlecry: Destroy one of your mana crystals.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFlameImp : MinionCard
    {
        public CardFlameImp()
        {
            BaseCost = 1;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108005;
            CardName = "Flame Imp";
            CardText = "Battlecry: Deal 3 damage to your hero.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardLordJaraxxus : MinionCard
    {
        public CardLordJaraxxus()
        {
            BaseCost = 9;
            BaseAttack = 3;
            BaseHealth = 15;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108006;
            CardName = "Lord Jaraxxus";
            CardText = "Battlecry: Destroy your hero and replace him with Lord Jaraxxus.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardPitLord : MinionCard
    {
        public CardPitLord()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108007;
            CardName = "Pit Lord";
            CardText = "Battlecry: Deal 5 damage to your hero.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Epic;
        }
    }

    class CardPowerOverwhelming : SpellCard
    {
        public CardPowerOverwhelming()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 108008;
            CardName = "Power Overwhelming";
            CardText = "Give a friendly minion +4/+4 until end of turn. Then, it dies. Horribly.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardSenseDemons : SpellCard
    {
        public CardSenseDemons()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 108009;
            CardName = "Sense Demons";
            CardText = "Put 2 random Demons from your deck into your hand.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardShadowflame : SpellCard
    {
        public CardShadowflame()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 108010;
            CardName = "Shadowflame";
            CardText = "Destroy a friendly minion and deal its attack damage to all enemy minions.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSiphonSoul : SpellCard
    {
        public CardSiphonSoul()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 108011;
            CardName = "Siphon Soul";
            CardText = "Destroy a minion. Restore 3 Health to your hero.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSummoningPortal : MinionCard
    {
        public CardSummoningPortal()
        {
            BaseCost = 4;
            BaseAttack = 0;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108012;
            CardName = "Summoning Portal";
            CardText = "Your minions cost (2) less, but not less than (1).";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardTwistingNether : SpellCard
    {
        public CardTwistingNether()
        {
            BaseCost = 8;
            RealCost = BaseCost;

            CardId = 108013;
            CardName = "Twisting Nether";
            CardText = "Destroy all minions.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Epic;
        }
    }

    class CardVoidTerror : MinionCard
    {
        public CardVoidTerror()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 108014;
            CardName = "Void Terror";
            CardText = "Battlecry: Destroy the minions on either side of this minion and gain their Attack and Health.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardArathiWeaponsmith : MinionCard
    {
        public CardArathiWeaponsmith()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 109000;
            CardName = "Arathi Weaponsmith";
            CardText = "Battlecry: Equip a 2/2 weapon.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardArmorsmith : MinionCard
    {
        public CardArmorsmith()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 109001;
            CardName = "Armorsmith";
            CardText = "Whenever a friendly minion takes damage, gain 1 Armor.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBattleRage : SpellCard
    {
        public CardBattleRage()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 109002;
            CardName = "Battle Rage";
            CardText = "Draw a card for each damaged friendly character.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardBrawl : SpellCard
    {
        public CardBrawl()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 109003;
            CardName = "Brawl";
            CardText = "Destroy all minions except one. (chosen randomly)";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Epic;
        }
    }

    class CardCommandingShout : SpellCard
    {
        public CardCommandingShout()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 109004;
            CardName = "Commanding Shout";
            CardText = "Your minions can't be reduced below 1 Health this turn. Draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCruelTaskmaster : MinionCard
    {
        public CardCruelTaskmaster()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 109005;
            CardName = "Cruel Taskmaster";
            CardText = "Battlecry: Deal 1 damage to a minion and give it +2 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardFrothingBerserker : MinionCard
    {
        public CardFrothingBerserker()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 109006;
            CardName = "Frothing Berserker";
            CardText = "Whenever a minion takes damage, gain +1 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardGorehowl : WeaponCard
    {
        public CardGorehowl()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseDurability = 1;
            RealCost = BaseCost;

            CardId = 109007;
            CardName = "Gorehowl";
            CardText = "Attacking a minion costs 1 Attack instead of 1 Durability.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Epic;
        }
    }

    class CardGrommashHellscream : MinionCard
    {
        public CardGrommashHellscream()
        {
            BaseCost = 8;
            BaseAttack = 4;
            BaseHealth = 9;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 109008;
            CardName = "Grommash Hellscream";
            CardText = "Charge. Enrage: +6 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardInnerRage : SpellCard
    {
        public CardInnerRage()
        {
            BaseCost = 0;
            RealCost = BaseCost;

            CardId = 109009;
            CardName = "Inner Rage";
            CardText = "Deal 1 damage to a minion and give it +2 Attack.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardMortalStrike : SpellCard
    {
        public CardMortalStrike()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 109010;
            CardName = "Mortal Strike";
            CardText = "Deal 4 damage. If you have 12 or less Health, deal 6 instead.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardRampage : SpellCard
    {
        public CardRampage()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 109011;
            CardName = "Rampage";
            CardText = "Give a damaged minion +3/+3.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardShieldSlam : SpellCard
    {
        public CardShieldSlam()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 109012;
            CardName = "Shield Slam";
            CardText = "Deal 1 damage to a minion for each armor you have.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSlam : SpellCard
    {
        public CardSlam()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 109013;
            CardName = "Slam";
            CardText = "Deal 2 damage to a minion. If it survives, draw a card.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardUpgrade : SpellCard
    {
        public CardUpgrade()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 109014;
            CardName = "Upgrade!";
            CardText = "If you have a weapon, give it +1/+1. Otherwise equip a 1/3 weapon.";
            CSet = CardSet.Classic;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBaronRivendare : MinionCard
    {
        public CardBaronRivendare()
        {
            BaseCost = 4;
            BaseAttack = 1;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200000;
            CardName = "Baron Rivendare";
            CardText = "Your minions trigger their Deathrattle twice.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardDancingSwords : MinionCard
    {
        public CardDancingSwords()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200001;
            CardName = "Dancing Swords";
            CardText = "Deathrattle: Your opponent draws a card.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardDeathlord : MinionCard
    {
        public CardDeathlord()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200002;
            CardName = "Deathlord";
            CardText = "Taunt. Deathrattle: Your opponents puts a minion from their deck into the battlefield.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardEchoingOoze : MinionCard
    {
        public CardEchoingOoze()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200003;
            CardName = "Echoing Ooze";
            CardText = "Battlecry: Summon an exact copy of this minion at the end of the turn.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardFeugan : MinionCard
    {
        public CardFeugan()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200004;
            CardName = "Feugan";
            CardText = "Deathrattle: If Stalagg also died this game, summon Thaddius.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardHauntedCreeper : MinionCard
    {
        public CardHauntedCreeper()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200005;
            CardName = "Haunted Creeper";
            CardText = "Deathrattle: Summon two 1/1 Spectral Spiders.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardKelthuzad : MinionCard
    {
        public CardKelthuzad()
        {
            BaseCost = 8;
            BaseAttack = 6;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200006;
            CardName = "Kel'thuzad";
            CardText = "At the end of each turn, summon all friendly minions that died this turn.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardLoatheb : MinionCard
    {
        public CardLoatheb()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200007;
            CardName = "Loatheb";
            CardText = "Battlecry: Enemy spells cost (5) more next turn.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMadScientist : MinionCard
    {
        public CardMadScientist()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200008;
            CardName = "Mad Scientist";
            CardText = "Deathrattle: Put a Secret from your deck into the battlefield.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMaexxna : MinionCard
    {
        public CardMaexxna()
        {
            BaseCost = 6;
            BaseAttack = 2;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200009;
            CardName = "Maexxna";
            CardText = "Destroy any minion damaged by this minion.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardNerubarWeblord : MinionCard
    {
        public CardNerubarWeblord()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200010;
            CardName = "Nerub'ar Weblord";
            CardText = "Minions with Battlecry cost (2) more.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardNerubianEgg : MinionCard
    {
        public CardNerubianEgg()
        {
            BaseCost = 2;
            BaseAttack = 0;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200011;
            CardName = "Nerubian Egg";
            CardText = "Deathrattle: Summon a 4/4 Nerubian.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardShadeofNaxxramas : MinionCard
    {
        public CardShadeofNaxxramas()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200012;
            CardName = "Shade of Naxxramas";
            CardText = "Stealth. At the start of your turn, gain +1/+1.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSludgeBelcher : MinionCard
    {
        public CardSludgeBelcher()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200013;
            CardName = "Sludge Belcher";
            CardText = "Taunt. Deathrattle: Summon a 1/2 Slime with Taunt.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSpectralKnight : MinionCard
    {
        public CardSpectralKnight()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200014;
            CardName = "Spectral Knight";
            CardText = "Can't be targetted by spells or Hero Powers.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardStalagg : MinionCard
    {
        public CardStalagg()
        {
            BaseCost = 5;
            BaseAttack = 7;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200015;
            CardName = "Stalagg";
            CardText = "Deathrattle: If Feugan also died this game, summon Thaddius.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardStoneskinGargoyle : MinionCard
    {
        public CardStoneskinGargoyle()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200016;
            CardName = "Stoneskin Gargoyle";
            CardText = "At the start of your turn, restore this minion to full Health.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardUndertaker : MinionCard
    {
        public CardUndertaker()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200017;
            CardName = "Undertaker";
            CardText = "Whenever you summon a minion with Deathrattle, gain +1/+1.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardUnstableGhoul : MinionCard
    {
        public CardUnstableGhoul()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200018;
            CardName = "Unstable Ghoul";
            CardText = "Taunt. Deathrattle: Deal 1 damage to all minions.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardWailingSoul : MinionCard
    {
        public CardWailingSoul()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200019;
            CardName = "Wailing Soul";
            CardText = "Battlecry: Silence your other minions.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardZombieChow : MinionCard
    {
        public CardZombieChow()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 200020;
            CardName = "Zombie Chow";
            CardText = "Deathrattle: Restore 5 Health to the enemy hero.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardPoisonSeeds : SpellCard
    {
        public CardPoisonSeeds()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 201000;
            CardName = "Poison Seeds";
            CardText = "Destroy all minions and summon 2/2 treants to replace them.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardWebspinner : MinionCard
    {
        public CardWebspinner()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 202000;
            CardName = "Webspinner";
            CardText = "Deathrattle: Add a random Beast card to your hand.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardDuplicate : SecretCard
    {
        public CardDuplicate()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 203000;
            CardName = "Duplicate";
            CardText = "Secret: When a friendly minion dies, put 2 copies of it into your hand.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardAvenge : SecretCard
    {
        public CardAvenge()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 204000;
            CardName = "Avenge";
            CardText = "Secret: When one of your minions dies, give a friendly minion +3/+2.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardDarkCultist : MinionCard
    {
        public CardDarkCultist()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 205000;
            CardName = "Dark Cultist";
            CardText = "Deathrattle: Give a random friendly minion +3 health.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardAnubarAmbusher : MinionCard
    {
        public CardAnubarAmbusher()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 206000;
            CardName = "Anub'ar Ambusher";
            CardText = "Deathrattle: Return a random friendly minion to your hand.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardReincarnate : SpellCard
    {
        public CardReincarnate()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 207000;
            CardName = "Reincarnate";
            CardText = "Destroy a minion, then return it to life with full Health.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardVoidcaller : MinionCard
    {
        public CardVoidcaller()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 208000;
            CardName = "Voidcaller";
            CardText = "Deathrattle: Put a random Demon from your hand into the battlefield.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardDeathsBite : WeaponCard
    {
        public CardDeathsBite()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 209000;
            CardName = "Death's Bite";
            CardText = "Deathrattle: Deal 1 damage to all minions.";
            CSet = CardSet.Naxxramas;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardAnnoyoTron : MinionCard
    {
        public CardAnnoyoTron()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300000;
            CardName = "Annoy-o-Tron";
            CardText = "Taunt. Divine Shield.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardAntiqueHealbot : MinionCard
    {
        public CardAntiqueHealbot()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300001;
            CardName = "Antique Healbot";
            CardText = "Battlecry: Restore 8 Health to your hero.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardArcaneNullifierX21 : MinionCard
    {
        public CardArcaneNullifierX21()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300002;
            CardName = "Arcane Nullifier X-21";
            CardText = "Taunt. Can't be targeted by spells or Hero Powers.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBlingtron3000 : MinionCard
    {
        public CardBlingtron3000()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300003;
            CardName = "Blingtron 3000";
            CardText = "Battlecry: Equip a random weapon for each player.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardBombLobber : MinionCard
    {
        public CardBombLobber()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300004;
            CardName = "Bomb Lobber";
            CardText = "Battlecry: Deal 4 damage to a random enemy minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBurlyRockjawTrogg : MinionCard
    {
        public CardBurlyRockjawTrogg()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300005;
            CardName = "Burly Rockjaw Trogg";
            CardText = "Whenever your opponents casts a spell, gain +2 attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardClockworkGiant : MinionCard
    {
        public CardClockworkGiant()
        {
            BaseCost = 12;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300006;
            CardName = "Clockwork Giant";
            CardText = "Costs (1) less Mana for each card in your opponent's hand.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardClockworkGnome : MinionCard
    {
        public CardClockworkGnome()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300007;
            CardName = "Clockwork Gnome";
            CardText = "Deathrattle: Put a Spare Part card in your hand.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardCogmaster : MinionCard
    {
        public CardCogmaster()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300008;
            CardName = "Cogmaster";
            CardText = "Has +2 attack while you have a Mech.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardDrBoom : MinionCard
    {
        public CardDrBoom()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300009;
            CardName = "Dr. Boom";
            CardText = "Battlecry: Summon two 1/1 Boom Bots. WARNING: Bots may explode.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardEnhanceoMechano : MinionCard
    {
        public CardEnhanceoMechano()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300010;
            CardName = "Enhance-o Mechano";
            CardText = "Battlecry: Give your other minions Windfury, Taunt, or Divine Shield (at random).";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardExplosiveSheep : MinionCard
    {
        public CardExplosiveSheep()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300011;
            CardName = "Explosive Sheep";
            CardText = "Deathrattle: Deal 2 damage to all minions.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardFelReaver : MinionCard
    {
        public CardFelReaver()
        {
            BaseCost = 5;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300012;
            CardName = "Fel Reaver";
            CardText = "Whenever your opponent plays a card, discard the top 3 cards of your deck.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardFlyingMachine : MinionCard
    {
        public CardFlyingMachine()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300013;
            CardName = "Flying Machine";
            CardText = "Windfury.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardFoeReaper4000 : MinionCard
    {
        public CardFoeReaper4000()
        {
            BaseCost = 8;
            BaseAttack = 6;
            BaseHealth = 9;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300014;
            CardName = "Foe Reaper 4000";
            CardText = "Also damages the minions next to whomever he attacks.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardForceTankMAX : MinionCard
    {
        public CardForceTankMAX()
        {
            BaseCost = 8;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300015;
            CardName = "Force-Tank MAX";
            CardText = "Divine Shield.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardGazlowe : MinionCard
    {
        public CardGazlowe()
        {
            BaseCost = 6;
            BaseAttack = 3;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300016;
            CardName = "Gazlowe";
            CardText = "Whenever you cast a 1-mana spell, add a random Mech to your hand.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardGilblinStalker : MinionCard
    {
        public CardGilblinStalker()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300017;
            CardName = "Gilblin Stalker";
            CardText = "Stealth.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardGnomereganInfantry : MinionCard
    {
        public CardGnomereganInfantry()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300018;
            CardName = "Gnomeregan Infantry";
            CardText = "Charge. Taunt.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardGnomishExperimenter : MinionCard
    {
        public CardGnomishExperimenter()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300019;
            CardName = "Gnomish Experimenter";
            CardText = "Battlecry: Draw a card. If it's a minion, transform it into a Chicken.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardGoblinSapper : MinionCard
    {
        public CardGoblinSapper()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300020;
            CardName = "Goblin Sapper";
            CardText = "Has +4 Attack while your opponent has 6 or more cards in hand.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardHemetNesingwary : MinionCard
    {
        public CardHemetNesingwary()
        {
            BaseCost = 5;
            BaseAttack = 6;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300021;
            CardName = "Hemet Nesingwary";
            CardText = "Battlecry: Destroy a Beast.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardHobgoblin : MinionCard
    {
        public CardHobgoblin()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300022;
            CardName = "Hobgoblin";
            CardText = "Whenever you play a 1-Attack minion, give it +2/+2.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardIlluminator : MinionCard
    {
        public CardIlluminator()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300023;
            CardName = "Illuminator";
            CardText = "If you control a Secret at the end of your turn, restore 4 health to your hero.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardJeeves : MinionCard
    {
        public CardJeeves()
        {
            BaseCost = 4;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300024;
            CardName = "Jeeves";
            CardText = "At the end of each player's turn, that player draws until they have 3 cards.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardJunkbot : MinionCard
    {
        public CardJunkbot()
        {
            BaseCost = 5;
            BaseAttack = 1;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300025;
            CardName = "Junkbot";
            CardText = "Whenver a friendly Mach dies, gain +2/+2.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardKezanMystic : MinionCard
    {
        public CardKezanMystic()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300026;
            CardName = "Kezan Mystic";
            CardText = "Battlecry: Take control of a random enemy Secret.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLilExorcist : MinionCard
    {
        public CardLilExorcist()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300027;
            CardName = "Lil' Exorcist";
            CardText = "Taunt. Battlecry: Gain +1/+1 for each enemy Deathrattle minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLostTallstrider : MinionCard
    {
        public CardLostTallstrider()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300028;
            CardName = "Lost Tallstrider";
            CardText = "";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMadderBomber : MinionCard
    {
        public CardMadderBomber()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300029;
            CardName = "Madder Bomber";
            CardText = "Battlecry: Deal 6 damage randomly split between all other characters.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMechanicalYeti : MinionCard
    {
        public CardMechanicalYeti()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300030;
            CardName = "Mechanical Yeti";
            CardText = "Deathrattle: Give each player a Spare Part.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMechwarper : MinionCard
    {
        public CardMechwarper()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300031;
            CardName = "Mechwarper";
            CardText = "Your Mechs cost (1) less.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMekgineerThermaplugg : MinionCard
    {
        public CardMekgineerThermaplugg()
        {
            BaseCost = 9;
            BaseAttack = 9;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300032;
            CardName = "Mekgineer Thermaplugg";
            CardText = "Whenever an enemy minions dies, summon a Leper Gnome.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMicroMachine : MinionCard
    {
        public CardMicroMachine()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300033;
            CardName = "Micro Machine";
            CardText = "At the start of each turn, gain +1 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMimironsHead : MinionCard
    {
        public CardMimironsHead()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300034;
            CardName = "Mimiron's Head";
            CardText = "At the start of your turn, if you have at least 3 Mechs, destroy them all and form V-07-TR-0N.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMiniMage : MinionCard
    {
        public CardMiniMage()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300035;
            CardName = "Mini-Mage";
            CardText = "Stealth. Spell Damage +1.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMogortheOgre : MinionCard
    {
        public CardMogortheOgre()
        {
            BaseCost = 6;
            BaseAttack = 7;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300036;
            CardName = "Mogor the Ogre";
            CardText = "All minions have a 50% chance to attack the wrong enemy.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardOgreBrute : MinionCard
    {
        public CardOgreBrute()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300037;
            CardName = "Ogre Brute";
            CardText = "50% chance to attack the wrong enemy.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardPilotedShredder : MinionCard
    {
        public CardPilotedShredder()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300038;
            CardName = "Piloted Shredder";
            CardText = "Deathrattle: Summon a random 2-cost minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardPilotedSkyGolem : MinionCard
    {
        public CardPilotedSkyGolem()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300039;
            CardName = "Piloted Sky Golem";
            CardText = "Deathrattle: Summon a random 4-cost minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardPuddlestomper : MinionCard
    {
        public CardPuddlestomper()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300040;
            CardName = "Puddlestomper";
            CardText = "";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardRecombobulator : MinionCard
    {
        public CardRecombobulator()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300041;
            CardName = "Recombobulator";
            CardText = "Battlecry: Transform a friendly minion into a random minion with the same Cost.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSaltyDog : MinionCard
    {
        public CardSaltyDog()
        {
            BaseCost = 5;
            BaseAttack = 7;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300042;
            CardName = "Salty Dog";
            CardText = "";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardShipsCannon : MinionCard
    {
        public CardShipsCannon()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300043;
            CardName = "Ship's Cannon";
            CardText = "Whenever you summon a Pirate, deal 2 damage to a random enemy.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSneedsOldShredder : MinionCard
    {
        public CardSneedsOldShredder()
        {
            BaseCost = 8;
            BaseAttack = 5;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300044;
            CardName = "Sneed's Old Shredder";
            CardText = "Deathrattle: Summon a random legendary minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardSpiderTank : MinionCard
    {
        public CardSpiderTank()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300045;
            CardName = "Spider Tank";
            CardText = "";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardStonesplinterTrogg : MinionCard
    {
        public CardStonesplinterTrogg()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300046;
            CardName = "Stonesplinter Trogg";
            CardText = "Whenever your opponent casts a spell, gain +1 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardTargetDummy : MinionCard
    {
        public CardTargetDummy()
        {
            BaseCost = 0;
            BaseAttack = 0;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300047;
            CardName = "Target Dummy";
            CardText = "Taunt.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardTinkertownTechnician : MinionCard
    {
        public CardTinkertownTechnician()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300048;
            CardName = "Tinkertown Technician";
            CardText = "Battlecry: If you control a Mech, gain +1/+1 and put a Spare Part in your hand.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardToshley : MinionCard
    {
        public CardToshley()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300049;
            CardName = "Toshley";
            CardText = "Battlecry and Deathrattle: Add a Spare Part card to your hand.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardTroggzortheEarthinator : MinionCard
    {
        public CardTroggzortheEarthinator()
        {
            BaseCost = 7;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 300050;
            CardName = "Troggzor the Earthinator";
            CardText = "Whenever your opponent casts a spell, summon a Burly Rockjaw Trogg.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardAnodizedRoboCub : MinionCard
    {
        public CardAnodizedRoboCub()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 301000;
            CardName = "Anodized Robo Cub";
            CardText = "Taunt. Choose one: +1 Attack; or +1 Health.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardDarkWispers : SpellCard
    {
        public CardDarkWispers()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 301001;
            CardName = "Dark Wispers";
            CardText = "Choose One - Summon 5 Wisps; or Give a minion +5/+5 and Taunt.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDruidoftheFang : MinionCard
    {
        public CardDruidoftheFang()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 301002;
            CardName = "Druid of the Fang";
            CardText = "Battlecry: If you have a Beast, transform this minion into a 7/7.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardGroveTender : MinionCard
    {
        public CardGroveTender()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 301003;
            CardName = "Grove Tender";
            CardText = "Choose One - Give each player a Mana Crystal; or Each player draws a card.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMalorne : MinionCard
    {
        public CardMalorne()
        {
            BaseCost = 7;
            BaseAttack = 9;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 301004;
            CardName = "Malorne";
            CardText = "Deathrattle: Shuffle this minion into your deck.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMechBearCat : MinionCard
    {
        public CardMechBearCat()
        {
            BaseCost = 6;
            BaseAttack = 7;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 301005;
            CardName = "Mech-Bear-Cat";
            CardText = "";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardRecycle : SpellCard
    {
        public CardRecycle()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 301006;
            CardName = "Recycle";
            CardText = "Shuffle an enemy minion into your opponent's deck.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardTreeofLife : SpellCard
    {
        public CardTreeofLife()
        {
            BaseCost = 9;
            RealCost = BaseCost;

            CardId = 301007;
            CardName = "Tree of Life";
            CardText = "Restore all characters to full Health.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Epic;
        }
    }

    class CardCallPet : SpellCard
    {
        public CardCallPet()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 302000;
            CardName = "Call Pet";
            CardText = "Draw a card, if it's a Beast it costs (4) less.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCobraShot : SpellCard
    {
        public CardCobraShot()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 302001;
            CardName = "Cobra Shot";
            CardText = "Deal 3 damage to a minion and the enemy hero.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardFeignDeath : SpellCard
    {
        public CardFeignDeath()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 302002;
            CardName = "Feign Death";
            CardText = "Trigger all Deathrattles on your minions.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardGahzrilla : MinionCard
    {
        public CardGahzrilla()
        {
            BaseCost = 7;
            BaseAttack = 6;
            BaseHealth = 9;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 302003;
            CardName = "Gahz'rilla";
            CardText = "Whenever this minion takes damage, double its Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardGlaivezooka : WeaponCard
    {
        public CardGlaivezooka()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 302004;
            CardName = "Glaivezooka";
            CardText = "Battlecry: Give a random friendly minion +1 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardKingofBeasts : MinionCard
    {
        public CardKingofBeasts()
        {
            BaseCost = 5;
            BaseAttack = 2;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 302005;
            CardName = "King of Beasts";
            CardText = "Taunt. Battlecry: Gain +1 Attack for each other Beast you have.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMetaltoothLeaper : MinionCard
    {
        public CardMetaltoothLeaper()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 302006;
            CardName = "Metaltooth Leaper";
            CardText = "Battlecry: Give your other Mechs +2 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSteamwheedleSniper : MinionCard
    {
        public CardSteamwheedleSniper()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 302007;
            CardName = "Steamwheedle Sniper";
            CardText = "Your Hero Power can target minions.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardEchoofMedivh : SpellCard
    {
        public CardEchoofMedivh()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 303000;
            CardName = "Echo of Medivh";
            CardText = "Put a copy of each friendly minion into your hand.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Epic;
        }
    }

    class CardFlameLeviathan : MinionCard
    {
        public CardFlameLeviathan()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 303001;
            CardName = "Flame Leviathan";
            CardText = "When you draw this, deal 2 damage to all characters.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardFlamecannon : SpellCard
    {
        public CardFlamecannon()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 303002;
            CardName = "Flamecannon";
            CardText = "Deal 4 damage to a random enemy minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardGoblinBlastmage : MinionCard
    {
        public CardGoblinBlastmage()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 303003;
            CardName = "Goblin Blastmage";
            CardText = "Battlecry: If you control a Mech, deal 4 damage randomly split among enemy characters.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSnowchugger : MinionCard
    {
        public CardSnowchugger()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 303004;
            CardName = "Snowchugger";
            CardText = "Freeze any character damaged by this minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardSootSpewer : MinionCard
    {
        public CardSootSpewer()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 303005;
            CardName = "Soot Spewer";
            CardText = "Spell Damage +1.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardUnstablePortal : SpellCard
    {
        public CardUnstablePortal()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 303006;
            CardName = "Unstable Portal";
            CardText = "Add a random minion to your hand. It costs (3) less.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWeeSpellstopper : MinionCard
    {
        public CardWeeSpellstopper()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 303007;
            CardName = "Wee Spellstopper";
            CardText = "Adjacent minions can't be targeted by spells or Hero Powers.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Epic;
        }
    }

    class CardBolvarFordragon : MinionCard
    {
        public CardBolvarFordragon()
        {
            BaseCost = 5;
            BaseAttack = 1;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 304000;
            CardName = "Bolvar Fordragon";
            CardText = "Whenever a friendly minion dies while this is in your hand, gain +1 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardCobaltGuardian : MinionCard
    {
        public CardCobaltGuardian()
        {
            BaseCost = 5;
            BaseAttack = 6;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 304001;
            CardName = "Cobalt Guardian";
            CardText = "Whenever you summon a Mech, gain Divine Shield.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCoghammer : WeaponCard
    {
        public CardCoghammer()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseDurability = 3;
            RealCost = BaseCost;

            CardId = 304002;
            CardName = "Coghammer";
            CardText = "Battlecry: Give a random friendly minion Divine Shield and Taunt.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMusterforBattle : SpellCard
    {
        public CardMusterforBattle()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 304003;
            CardName = "Muster for Battle";
            CardText = "Summon three 1/1 Silver Hand Recruits. Equip a 1/4 Weapon.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardQuartermaster : MinionCard
    {
        public CardQuartermaster()
        {
            BaseCost = 5;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 304004;
            CardName = "Quartermaster";
            CardText = "Battlecry: Give your Silver Hand Recruits +2/+2.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Epic;
        }
    }

    class CardScarletPurifier : MinionCard
    {
        public CardScarletPurifier()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 304005;
            CardName = "Scarlet Purifier";
            CardText = "Battlecry: Deal 2 damage to all minions with Deathrattle.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSealofLight : SpellCard
    {
        public CardSealofLight()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 304006;
            CardName = "Seal of Light";
            CardText = "Restore 4 Health to your hero and gain +2 Attack this turn.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardShieldedMinibot : MinionCard
    {
        public CardShieldedMinibot()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 304007;
            CardName = "Shielded Minibot";
            CardText = "Divine Shield.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardLightoftheNaaru : SpellCard
    {
        public CardLightoftheNaaru()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 305000;
            CardName = "Light of the Naaru";
            CardText = "Restore 3 Health. If the target is still damaged, summon a Lightwarden.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLightbomb : SpellCard
    {
        public CardLightbomb()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 305001;
            CardName = "Lightbomb";
            CardText = "Deal damage to each minion equal to its Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Epic;
        }
    }

    class CardShadowbomber : MinionCard
    {
        public CardShadowbomber()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 305002;
            CardName = "Shadowbomber";
            CardText = "Battlecry: Deal 3 damage to each hero.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Epic;
        }
    }

    class CardShadowboxer : MinionCard
    {
        public CardShadowboxer()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 305003;
            CardName = "Shadowboxer";
            CardText = "Whenever a character is healed, deal 1 damage to a random enemy.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardShrinkmeister : MinionCard
    {
        public CardShrinkmeister()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 305004;
            CardName = "Shrinkmeister";
            CardText = "Battlecry: Give a minion -2 attack this turn.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardUpgradedRepairBot : MinionCard
    {
        public CardUpgradedRepairBot()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 305005;
            CardName = "Upgraded Repair Bot";
            CardText = "Battlecry: Give a friendly Mech +4 health.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardVelensChosen : SpellCard
    {
        public CardVelensChosen()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 305006;
            CardName = "Velen's Chosen";
            CardText = "Give a minion +2/+4 and Spell Damage +1.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardVoljin : MinionCard
    {
        public CardVoljin()
        {
            BaseCost = 5;
            BaseAttack = 6;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 305007;
            CardName = "Vol'jin";
            CardText = "Battlecry: Swap Health with another minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardCogmastersWrench : WeaponCard
    {
        public CardCogmastersWrench()
        {
            BaseCost = 3;
            BaseAttack = 1;
            BaseDurability = 3;
            RealCost = BaseCost;

            CardId = 306000;
            CardName = "Cogmaster's Wrench";
            CardText = "Has +2 Attack while you have a Mech.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Epic;
        }
    }

    class CardGoblinAutoBarber : MinionCard
    {
        public CardGoblinAutoBarber()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 306001;
            CardName = "Goblin Auto-Barber";
            CardText = "Battlecry: Give your weapon +1 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardIronSensei : MinionCard
    {
        public CardIronSensei()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 306002;
            CardName = "Iron Sensei";
            CardText = "At the end of your turn, give another friendly Mech +2/+2.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardOgreNinja : MinionCard
    {
        public CardOgreNinja()
        {
            BaseCost = 5;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 306003;
            CardName = "Ogre Ninja";
            CardText = "Stealth. 50% chance to attack the wrong enemy.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardOneEyedCheat : MinionCard
    {
        public CardOneEyedCheat()
        {
            BaseCost = 2;
            BaseAttack = 4;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 306004;
            CardName = "One-Eyed Cheat";
            CardText = "Whenever you summon a Pirate, gain Stealth.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSabotage : SpellCard
    {
        public CardSabotage()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 306005;
            CardName = "Sabotage";
            CardText = "Destroy a random enemy minion. Combo: And your opponent's weapon.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Epic;
        }
    }

    class CardTinkersSharpswordOil : SpellCard
    {
        public CardTinkersSharpswordOil()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 306006;
            CardName = "Tinker's Sharpsword Oil";
            CardText = "Give your weapon +3 Attack. Combo: Give a random friendly minion +3 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardTradePrinceGallywix : MinionCard
    {
        public CardTradePrinceGallywix()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 306007;
            CardName = "Trade Prince Gallywix";
            CardText = "Whenever your opponent casts a spell, gain a copy of it and give them a Coin.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardAncestorsCall : SpellCard
    {
        public CardAncestorsCall()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 307000;
            CardName = "Ancestor's Call";
            CardText = "Put a random minion from each player's hand into the battlefield.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Epic;
        }
    }

    class CardCrackle : SpellCard
    {
        public CardCrackle()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 307001;
            CardName = "Crackle";
            CardText = "Deal 3-6 damage. Overload (1)";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardDunemaulShaman : MinionCard
    {
        public CardDunemaulShaman()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 307002;
            CardName = "Dunemaul Shaman";
            CardText = "Windfury. 50% chance to attack the wrong enemy. Overload: (1)";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardNeptulon : MinionCard
    {
        public CardNeptulon()
        {
            BaseCost = 7;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 307003;
            CardName = "Neptulon";
            CardText = "Battlecry: Add 4 random Murlocs to your hand. Overload: (3)";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardPowermace : WeaponCard
    {
        public CardPowermace()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 307004;
            CardName = "Powermace";
            CardText = "Deathrattle: Give a random friendly Mech +2/+2.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSiltfinSpiritwalker : MinionCard
    {
        public CardSiltfinSpiritwalker()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 307005;
            CardName = "Siltfin Spiritwalker";
            CardText = "";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Epic;
        }
    }

    class CardVitalityTotem : MinionCard
    {
        public CardVitalityTotem()
        {
            BaseCost = 2;
            BaseAttack = 0;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 307006;
            CardName = "Vitality Totem";
            CardText = "At the end of your turn, restore 4 Health to your hero.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWhirlingZapomatic : MinionCard
    {
        public CardWhirlingZapomatic()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 307007;
            CardName = "Whirling Zap-o-matic";
            CardText = "Windfury.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardAnimaGolem : MinionCard
    {
        public CardAnimaGolem()
        {
            BaseCost = 6;
            BaseAttack = 9;
            BaseHealth = 9;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 308000;
            CardName = "Anima Golem";
            CardText = "At the end of each turn, destroy this minion if it's your only one.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDarkbomb : SpellCard
    {
        public CardDarkbomb()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 308001;
            CardName = "Darkbomb";
            CardText = "Deal 3 damage.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardDemonheart : SpellCard
    {
        public CardDemonheart()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 308002;
            CardName = "Demonheart";
            CardText = "Deal 5 damage to a minion. If it’s a friendly Demon, give it +5/+5 instead.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Epic;
        }
    }

    class CardFelCannon : MinionCard
    {
        public CardFelCannon()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 308003;
            CardName = "Fel Cannon";
            CardText = "At the end of your turn, deal 2 damage to a non-Mech minion.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFloatingWatcher : MinionCard
    {
        public CardFloatingWatcher()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 308004;
            CardName = "Floating Watcher";
            CardText = "Whenever your hero takes damage on your turn, gain +2/+2.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardImplosion : SpellCard
    {
        public CardImplosion()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 308005;
            CardName = "Imp-losion";
            CardText = "Deal 2-4 damage to a minion. Summon a 1/1 Imp for each damage dealt.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMalGanis : MinionCard
    {
        public CardMalGanis()
        {
            BaseCost = 9;
            BaseAttack = 9;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 308006;
            CardName = "Mal'Ganis";
            CardText = "Your other Demons have +2/+2. Your hero is Immune.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardMistressofPain : MinionCard
    {
        public CardMistressofPain()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 308007;
            CardName = "Mistress of Pain";
            CardText = "Whenever this minion deals damage, restore that much Health to your hero.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBouncingBlade : SpellCard
    {
        public CardBouncingBlade()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 309000;
            CardName = "Bouncing Blade";
            CardText = "Deal 1 damage to a random minion. Repeat until a minion dies.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Epic;
        }
    }

    class CardCrush : SpellCard
    {
        public CardCrush()
        {
            BaseCost = 7;
            RealCost = BaseCost;

            CardId = 309001;
            CardName = "Crush";
            CardText = "Destroy a minion. If you have a damaged minion, this costs (4) less.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Epic;
        }
    }

    class CardIronJuggernaut : MinionCard
    {
        public CardIronJuggernaut()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 309002;
            CardName = "Iron Juggernaut";
            CardText = "Battlecry: Shuffle a Mine into your opponent's deck. When drawn, it explodes for 10 damage.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardOgreWarmaul : WeaponCard
    {
        public CardOgreWarmaul()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 309003;
            CardName = "Ogre Warmaul";
            CardText = "50% chance to attack the wrong enemy.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardScrewjankClunker : MinionCard
    {
        public CardScrewjankClunker()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 309004;
            CardName = "Screwjank Clunker";
            CardText = "Battlecry: Give a friendly Mech +2/+2.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardShieldmaiden : MinionCard
    {
        public CardShieldmaiden()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 309005;
            CardName = "Shieldmaiden";
            CardText = "Battlecry: Gain 5 Armor.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSiegeEngine : MinionCard
    {
        public CardSiegeEngine()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 309006;
            CardName = "Siege Engine";
            CardText = "Whenever you gain Armor, give this minion +1 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWarbot : MinionCard
    {
        public CardWarbot()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 309007;
            CardName = "Warbot";
            CardText = "Enrage: +1 Attack.";
            CSet = CardSet.GoblinsVsGnomesGrand;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardBlackwingCorruptor : MinionCard
    {
        public CardBlackwingCorruptor()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400000;
            CardName = "Blackwing Corruptor";
            CardText = "Battlecry: If you're holding a Dragon, deal 3 damage.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardBlackwingTechnician : MinionCard
    {
        public CardBlackwingTechnician()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400001;
            CardName = "Blackwing Technician";
            CardText = "Battlecry: If you're holding a Dragon, gain +1/+1.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardChromaggus : MinionCard
    {
        public CardChromaggus()
        {
            BaseCost = 8;
            BaseAttack = 6;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400002;
            CardName = "Chromaggus";
            CardText = "Whenever you draw a card, put another copy into your hand.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardDragonEgg : MinionCard
    {
        public CardDragonEgg()
        {
            BaseCost = 1;
            BaseAttack = 0;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400003;
            CardName = "Dragon Egg";
            CardText = "Whenever this minion takes damage, summon a 2/1 Whelp.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardDragonkinSorcerer : MinionCard
    {
        public CardDragonkinSorcerer()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400004;
            CardName = "Dragonkin Sorcerer";
            CardText = "Whenever you target this minion with a spell, gain +1/+1.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardDrakonidCrusher : MinionCard
    {
        public CardDrakonidCrusher()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400005;
            CardName = "Drakonid Crusher";
            CardText = "Battlecry: If your opponent has 15 or less Health, gain +3/+3.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardEmperorThaurissan : MinionCard
    {
        public CardEmperorThaurissan()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400006;
            CardName = "Emperor Thaurissan";
            CardText = "At the end of your turn, reduce the Cost of cards in your hand by (1).";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardGrimPatron : MinionCard
    {
        public CardGrimPatron()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400007;
            CardName = "Grim Patron";
            CardText = "Whenever this minion survives damage, summon another Grim Patron.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardHungryDragon : MinionCard
    {
        public CardHungryDragon()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400008;
            CardName = "Hungry Dragon";
            CardText = "Battlecry: Summon a random 1-cost minion for your opponent.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMajordomoExecutus : MinionCard
    {
        public CardMajordomoExecutus()
        {
            BaseCost = 9;
            BaseAttack = 9;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400009;
            CardName = "Majordomo Executus";
            CardText = "Deathrattle: Replace your hero with Ragnaros, the Firelord.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardNefarian : MinionCard
    {
        public CardNefarian()
        {
            BaseCost = 9;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400010;
            CardName = "Nefarian";
            CardText = "Battlecry: Add 2 random spells to your hand (from your opponent's class).";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardRendBlackhand : MinionCard
    {
        public CardRendBlackhand()
        {
            BaseCost = 7;
            BaseAttack = 8;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400011;
            CardName = "Rend Blackhand";
            CardText = "Battlecry: If you're holding a Dragon, destroy a Legendary minion.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardVolcanicDrake : MinionCard
    {
        public CardVolcanicDrake()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 400012;
            CardName = "Volcanic Drake";
            CardText = "Costs (1) less for each minion that died this turn.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardDruidoftheFlame : MinionCard
    {
        public CardDruidoftheFlame()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 401000;
            CardName = "Druid of the Flame";
            CardText = "Choose One - Transform into a 5/2 minion; or a 2/5 minion.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardVolcanicLumberer : MinionCard
    {
        public CardVolcanicLumberer()
        {
            BaseCost = 9;
            BaseAttack = 7;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 401001;
            CardName = "Volcanic Lumberer";
            CardText = "Taunt. Costs (1) less for each minion that died this turn.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCoreRager : MinionCard
    {
        public CardCoreRager()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 402000;
            CardName = "Core Rager";
            CardText = "Battlecry: If your hand is empty, gain +3/+3.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardQuickShot : SpellCard
    {
        public CardQuickShot()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 402001;
            CardName = "Quick Shot";
            CardText = "Deal 3 damage. If your hand is empty, draw a card.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardDragonsBreath : SpellCard
    {
        public CardDragonsBreath()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 403000;
            CardName = "Dragon's Breath";
            CardText = "Deal 4 damage. Costs (1) less for each minion that died this turn.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardFlamewaker : MinionCard
    {
        public CardFlamewaker()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 403001;
            CardName = "Flamewaker";
            CardText = "After you cast a spell, deal 2 damage randomly split among all enemies.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardDragonConsort : MinionCard
    {
        public CardDragonConsort()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 404000;
            CardName = "Dragon Consort";
            CardText = "Battlecry: The next Dragon you play costs (2) less.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSolemnVigil : SpellCard
    {
        public CardSolemnVigil()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 404001;
            CardName = "Solemn Vigil";
            CardText = "Draw 2 cards. Costs (1) less for each minion that died this turn.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardResurrect : SpellCard
    {
        public CardResurrect()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 405000;
            CardName = "Resurrect";
            CardText = "Summon a random friendly minion that died this game.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardTwilightWhelp : MinionCard
    {
        public CardTwilightWhelp()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 405001;
            CardName = "Twilight Whelp";
            CardText = "Battlecry: If you're holding a Dragon, gain +2 Health.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardDarkIronSkulker : MinionCard
    {
        public CardDarkIronSkulker()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 406000;
            CardName = "Dark Iron Skulker";
            CardText = "Battlecry: Deal 2 damage to all undamaged enemy minions.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardGangUp : SpellCard
    {
        public CardGangUp()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 406001;
            CardName = "Gang Up";
            CardText = "Choose a minion. Shuffle 3 copies of it into your deck.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardFireguardDestroyer : MinionCard
    {
        public CardFireguardDestroyer()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 407000;
            CardName = "Fireguard Destroyer";
            CardText = "Battlecry: Gain 1-4 Attack. Overload: (1)";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardLavaShock : SpellCard
    {
        public CardLavaShock()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 407001;
            CardName = "Lava Shock";
            CardText = "Deal 2 damage. Unlock your Overloaded Mana Crystals.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardDemonwrath : SpellCard
    {
        public CardDemonwrath()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 408000;
            CardName = "Demonwrath";
            CardText = "Deal 2 damage to all non-Demon minions.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardImpGangBoss : MinionCard
    {
        public CardImpGangBoss()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 408001;
            CardName = "Imp Gang Boss";
            CardText = "Whenever this minion takes damage, summon a 1/1 Imp.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardAxeFlinger : MinionCard
    {
        public CardAxeFlinger()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 409000;
            CardName = "Axe Flinger";
            CardText = "Whenever this minion takes damage, deal 2 damage to the enemy hero.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardRevenge : SpellCard
    {
        public CardRevenge()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 409001;
            CardName = "Revenge";
            CardText = "Deal 1 damage to all minions. If you have 12 or less health, deal 3 damage instead.";
            CSet = CardSet.BlackrockMountain;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardArgentHorserider : MinionCard
    {
        public CardArgentHorserider()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500000;
            CardName = "Argent Horserider";
            CardText = "Divine Shield Charge";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardArgentWatchman : MinionCard
    {
        public CardArgentWatchman()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500001;
            CardName = "Argent Watchman";
            CardText = "Can't attack. Inspire: Can attack as normal this turn.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardArmoredWarhorse : MinionCard
    {
        public CardArmoredWarhorse()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500002;
            CardName = "Armored Warhorse";
            CardText = "Battlecry: Reveal a minion in each deck. If yours costs more, gain Charge.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBolfRamshield : MinionCard
    {
        public CardBolfRamshield()
        {
            BaseCost = 6;
            BaseAttack = 3;
            BaseHealth = 9;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500003;
            CardName = "Bolf Ramshield";
            CardText = "Whenever your hero takes damage, this minion takes it instead.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardBoneguardLieutenant : MinionCard
    {
        public CardBoneguardLieutenant()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500004;
            CardName = "Boneguard Lieutenant";
            CardText = "Inspire: Gain +1 Health.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardCapturedJormungar : MinionCard
    {
        public CardCapturedJormungar()
        {
            BaseCost = 7;
            BaseAttack = 5;
            BaseHealth = 9;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500005;
            CardName = "Captured Jormungar";
            CardText = "";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardChillmaw : MinionCard
    {
        public CardChillmaw()
        {
            BaseCost = 7;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500006;
            CardName = "Chillmaw";
            CardText = "Taunt, Deathratt:e If you're holding a Dragon, deal 3 damage to all minions.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardClockworkKnight : MinionCard
    {
        public CardClockworkKnight()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500007;
            CardName = "Clockwork Knight";
            CardText = "Battlecry: Give a friendly Mech +1/+1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardColiseumManager : MinionCard
    {
        public CardColiseumManager()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500008;
            CardName = "Coliseum Manager";
            CardText = "Inspire: Return this minion to your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCrowdFavorite : MinionCard
    {
        public CardCrowdFavorite()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500009;
            CardName = "Crowd Favorite";
            CardText = "Whenever you play a card with Battlecry, gain +1/+1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDragonhawkRider : MinionCard
    {
        public CardDragonhawkRider()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500010;
            CardName = "Dragonhawk Rider";
            CardText = "Inspire: Gain Windfury this turn.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardEvilHeckler : MinionCard
    {
        public CardEvilHeckler()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500011;
            CardName = "Evil Heckler";
            CardText = "Taunt";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardEydisDarkbane : MinionCard
    {
        public CardEydisDarkbane()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500012;
            CardName = "Eydis Darkbane";
            CardText = "Whenever you target this minion with a spell, deal 3 damage to a random enemy.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardFencingCoach : MinionCard
    {
        public CardFencingCoach()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500013;
            CardName = "Fencing Coach";
            CardText = "Battlecry: The next time you use your Hero Power, it costs (2) less.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFjolaLightbane : MinionCard
    {
        public CardFjolaLightbane()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500014;
            CardName = "Fjola Lightbane";
            CardText = "Whenever you target this minion with a spell, gain Divine Shield.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardFlameJuggler : MinionCard
    {
        public CardFlameJuggler()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500015;
            CardName = "Flame Juggler";
            CardText = "Battlecry: Deal 1 damage to a random enemy.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardFrigidSnobold : MinionCard
    {
        public CardFrigidSnobold()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500016;
            CardName = "Frigid Snobold";
            CardText = "Spell Damage +1";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardFrostGiant : MinionCard
    {
        public CardFrostGiant()
        {
            BaseCost = 10;
            BaseAttack = 8;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500017;
            CardName = "Frost Giant";
            CardText = "Costs (1) less for each time you used your Hero Power this game.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardGadgetzanJouster : MinionCard
    {
        public CardGadgetzanJouster()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500018;
            CardName = "Gadgetzan Jouster";
            CardText = "Battlecry: Reveal a minion in each deck. If yours costs more, gain +1/+1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardGarrisonCommander : MinionCard
    {
        public CardGarrisonCommander()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500019;
            CardName = "Garrison Commander";
            CardText = "You can use your Hero Power twice on your turn.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardGormoktheImpaler : MinionCard
    {
        public CardGormoktheImpaler()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500020;
            CardName = "Gormok the Impaler";
            CardText = "Battlecry: If you have at least 4 other minions, deal 4 damage.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardGrandCrusader : MinionCard
    {
        public CardGrandCrusader()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500021;
            CardName = "Grand Crusader";
            CardText = "Battlecry: Add a random Paladin card to your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardIceRager : MinionCard
    {
        public CardIceRager()
        {
            BaseCost = 3;
            BaseAttack = 5;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500022;
            CardName = "Ice Rager";
            CardText = "";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardIcehowl : MinionCard
    {
        public CardIcehowl()
        {
            BaseCost = 9;
            BaseAttack = 10;
            BaseHealth = 10;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500023;
            CardName = "Icehowl";
            CardText = "Charge Can't attack Heroes.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardInjuredKvaldir : MinionCard
    {
        public CardInjuredKvaldir()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500024;
            CardName = "Injured Kvaldir";
            CardText = "Battlecry: Deal 3 damage to this minion.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardJusticarTrueheart : MinionCard
    {
        public CardJusticarTrueheart()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500025;
            CardName = "Justicar Trueheart";
            CardText = "Battlecry: Replace your starting Hero Power with a better one.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardKodorider : MinionCard
    {
        public CardKodorider()
        {
            BaseCost = 6;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500026;
            CardName = "Kodorider";
            CardText = "Inspire: Summon a 3/5 War Kodo.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardKvaldirRaider : MinionCard
    {
        public CardKvaldirRaider()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500027;
            CardName = "Kvaldir Raider";
            CardText = "Inspire: Gain +2/+2.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardLanceBearer : MinionCard
    {
        public CardLanceBearer()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500028;
            CardName = "Lance Bearer";
            CardText = "Battlecry: Give a friendly minion +2 Attack.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardLightsChampion : MinionCard
    {
        public CardLightsChampion()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500029;
            CardName = "Light’s Champion";
            CardText = "Battlecry: Silence a Demon.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLowlySquire : MinionCard
    {
        public CardLowlySquire()
        {
            BaseCost = 1;
            BaseAttack = 1;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500030;
            CardName = "Lowly Squire";
            CardText = "Inspire: Gain +1 Attack.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMaidenoftheLake : MinionCard
    {
        public CardMaidenoftheLake()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500031;
            CardName = "Maiden of the Lake";
            CardText = "Your Hero Power costs (1).";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardMasterJouster : MinionCard
    {
        public CardMasterJouster()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500032;
            CardName = "Master Jouster";
            CardText = "Battlecry: Reveal a minion in each deck. If yours costs more, gain Taunt and Divine Shield.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMasterofCeremonies : MinionCard
    {
        public CardMasterofCeremonies()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500033;
            CardName = "Master of Ceremonies";
            CardText = "Battlecry: If you have a minion with Spell Damage, gain +2/+2.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMogorsChampion : MinionCard
    {
        public CardMogorsChampion()
        {
            BaseCost = 6;
            BaseAttack = 8;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500034;
            CardName = "Mogor’s Champion";
            CardText = "50% chance to attack the wrong enemy.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMuklasChampion : MinionCard
    {
        public CardMuklasChampion()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500035;
            CardName = "Mukla’s Champion";
            CardText = "Inspire: Give your other minions +1/+1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardNexusChampionSaraad : MinionCard
    {
        public CardNexusChampionSaraad()
        {
            BaseCost = 5;
            BaseAttack = 4;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500036;
            CardName = "Nexus-Champion Saraad";
            CardText = "Inspire: Add a random spell to your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardNorthSeaKraken : MinionCard
    {
        public CardNorthSeaKraken()
        {
            BaseCost = 9;
            BaseAttack = 9;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500037;
            CardName = "North Sea Kraken";
            CardText = "Battlecry: Deal 4 damage.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardPitFighter : MinionCard
    {
        public CardPitFighter()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500038;
            CardName = "Pit Fighter";
            CardText = "";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardRecruiter : MinionCard
    {
        public CardRecruiter()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500039;
            CardName = "Recruiter";
            CardText = "Inspire: Add a 2/2 Squire to your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardRefreshmentVendor : MinionCard
    {
        public CardRefreshmentVendor()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500040;
            CardName = "Refreshment Vendor";
            CardText = "Battlecry: Restore 4 Health to each hero.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSaboteur : MinionCard
    {
        public CardSaboteur()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500041;
            CardName = "Saboteur";
            CardText = "Battlecry: Your opponent's hero Power costs (5) more next turn.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Rare;
        }
    }

    class CardSideshowSpelleater : MinionCard
    {
        public CardSideshowSpelleater()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500042;
            CardName = "Sideshow Spelleater";
            CardText = "Battlecry: Copy your opponent's Hero Power.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSilentKnight : MinionCard
    {
        public CardSilentKnight()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500043;
            CardName = "Silent Knight";
            CardText = "Stealth Divine Shield";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSilverHandRegent : MinionCard
    {
        public CardSilverHandRegent()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500044;
            CardName = "Silver Hand Regent";
            CardText = "Inspire: Summon a 1/1 Silver Hand Recruit.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardSkycapnKragg : MinionCard
    {
        public CardSkycapnKragg()
        {
            BaseCost = 7;
            BaseAttack = 4;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500045;
            CardName = "Skycap’n Kragg";
            CardText = "Charrrrrge Costs (1) less for each friendly Pirate.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardTheSkeletonKnight : MinionCard
    {
        public CardTheSkeletonKnight()
        {
            BaseCost = 6;
            BaseAttack = 7;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500046;
            CardName = "The Skeleton Knight";
            CardText = "Deathrattle: Reveal a minion in each deck. If yours costs more, return this to your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardTournamentAttendee : MinionCard
    {
        public CardTournamentAttendee()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500047;
            CardName = "Tournament Attendee";
            CardText = "Taunt";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardTournamentMedic : MinionCard
    {
        public CardTournamentMedic()
        {
            BaseCost = 4;
            BaseAttack = 1;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500048;
            CardName = "Tournament Medic";
            CardText = "Inspire: Restore 2 Health to your hero.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Common;
        }
    }

    class CardTwilightGuardian : MinionCard
    {
        public CardTwilightGuardian()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 500049;
            CardName = "Twilight Guardian";
            CardText = "Battlecry: If you're holding a Dragon, gain +1 Attack and Taunt.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Neutral;
            CRarity = CardRarity.Epic;
        }
    }

    class CardAstralCommunion : SpellCard
    {
        public CardAstralCommunion()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 501000;
            CardName = "Astral Communion";
            CardText = "Gain 10 Mana Crystals. Discard your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Epic;
        }
    }

    class CardAviana : MinionCard
    {
        public CardAviana()
        {
            BaseCost = 9;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 501001;
            CardName = "Aviana";
            CardText = "Your minions cost (1).";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardDarnassusAspirant : MinionCard
    {
        public CardDarnassusAspirant()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 501002;
            CardName = "Darnassus Aspirant";
            CardText = "Battlecry: Gain an empty Mana Crystal. Deathrattle: Destroy one of your Mana Crystals.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardDruidoftheSaber : MinionCard
    {
        public CardDruidoftheSaber()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 501003;
            CardName = "Druid of the Saber";
            CardText = "Choose One - Charge; or +1/+1 and Stealth.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardKnightoftheWild : MinionCard
    {
        public CardKnightoftheWild()
        {
            BaseCost = 7;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 501004;
            CardName = "Knight of the Wild";
            CardText = "Whenever you summon a Beast, reduce the Cost of this card by (1).";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardLivingRoots : SpellCard
    {
        public CardLivingRoots()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 501005;
            CardName = "Living Roots";
            CardText = "Choose One - Deal 2 damage; or Summon two 1/1 Saplings.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardMulch : SpellCard
    {
        public CardMulch()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 501006;
            CardName = "Mulch";
            CardText = "Destroy a minion. Add a random minion to your opponent's hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSavageCombatant : MinionCard
    {
        public CardSavageCombatant()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 501007;
            CardName = "Savage Combatant";
            CardText = "Inspire: Give your hero +2 Attack this turn.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWildwalker : MinionCard
    {
        public CardWildwalker()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 501008;
            CardName = "Wildwalker";
            CardText = "Battlecry: Give a friendly Beast +3 Health.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Druid;
            CRarity = CardRarity.Common;
        }
    }

    class CardAcidmaw : MinionCard
    {
        public CardAcidmaw()
        {
            BaseCost = 7;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 502000;
            CardName = "Acidmaw";
            CardText = "Whenever another minion takes damage, destroy it.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardBallofSpiders : SpellCard
    {
        public CardBallofSpiders()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 502001;
            CardName = "Ball of Spiders";
            CardText = "Summon three 1/1 Webspinners.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBearTrap : SecretCard
    {
        public CardBearTrap()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 502002;
            CardName = "Bear Trap";
            CardText = "Secret: After your hero is attacked, summon a 3/3 Bear with Taunt.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardBraveArcher : MinionCard
    {
        public CardBraveArcher()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 502003;
            CardName = "Brave Archer";
            CardText = "Inspire: If your hand is empty, deal 2 damage to the enemy hero.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardDreadscale : MinionCard
    {
        public CardDreadscale()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 502004;
            CardName = "Dreadscale";
            CardText = "At the end of your turn, deal 2 damage to all other minions.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardKingsElekk : MinionCard
    {
        public CardKingsElekk()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 502005;
            CardName = "King’s Elekk";
            CardText = "Battlecry: Reveal a minion in each deck. If yours costs more, draw it.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Common;
        }
    }

    class CardLockandLoad : SpellCard
    {
        public CardLockandLoad()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 502006;
            CardName = "Lock and Load";
            CardText = "Each time you cast a spell this turn, add a random Hunter card to your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardPowershot : SpellCard
    {
        public CardPowershot()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 502007;
            CardName = "Powershot";
            CardText = "Deal 2 damage to a minion and the minions next to it.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardRamWrangler : MinionCard
    {
        public CardRamWrangler()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 502008;
            CardName = "Ram Wrangler";
            CardText = "Battlecry: If you have a Beast, summon a random Beast.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Rare;
        }
    }

    class CardStablemaster : MinionCard
    {
        public CardStablemaster()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 502009;
            CardName = "Stablemaster";
            CardText = "Battlecry: Give a friendly Beast Immune this turn.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Hunter;
            CRarity = CardRarity.Epic;
        }
    }

    class CardArcaneBlast : SpellCard
    {
        public CardArcaneBlast()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 503000;
            CardName = "Arcane Blast";
            CardText = "Deal 2 damage to a minion. This spell gets double bonus from Spell Damage.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Epic;
        }
    }

    class CardColdarraDrake : MinionCard
    {
        public CardColdarraDrake()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 503001;
            CardName = "Coldarra Drake";
            CardText = "You can use your Hero Power any number of times.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDalaranAspirant : MinionCard
    {
        public CardDalaranAspirant()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 503002;
            CardName = "Dalaran Aspirant";
            CardText = "Inspire: Gain Spell Damage +1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardEffigy : SpellCard
    {
        public CardEffigy()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 503003;
            CardName = "Effigy";
            CardText = "Secret: When a friendly minion dies, summon a random minion with the same Cost.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFallenHero : MinionCard
    {
        public CardFallenHero()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 503004;
            CardName = "Fallen Hero";
            CardText = "Your Hero Power deals 1 extra damage.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFlameLance : SpellCard
    {
        public CardFlameLance()
        {
            BaseCost = 5;
            RealCost = BaseCost;

            CardId = 503005;
            CardName = "Flame Lance";
            CardText = "Deal 8 damage to a minion.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardPolymorphBoar : SpellCard
    {
        public CardPolymorphBoar()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 503006;
            CardName = "Polymorph: Boar";
            CardText = "Transform a minion into a 4/2 Boar with Charge.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Rare;
        }
    }

    class CardRhonin : MinionCard
    {
        public CardRhonin()
        {
            BaseCost = 8;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 503007;
            CardName = "Rhonin";
            CardText = "Deathrattle: Add 3 copies of Arcane Missiles to your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardSpellslinger : MinionCard
    {
        public CardSpellslinger()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 503008;
            CardName = "Spellslinger";
            CardText = "Battlecry: Add a random spell card to each player's hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Mage;
            CRarity = CardRarity.Common;
        }
    }

    class CardArgentLance : WeaponCard
    {
        public CardArgentLance()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 504000;
            CardName = "Argent Lance";
            CardText = "Battlecry: Reveal a minion in each deck. If yours costs more, +1 Durability.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCompetitiveSpirit : SpellCard
    {
        public CardCompetitiveSpirit()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 504001;
            CardName = "Competitive Spirit";
            CardText = "Secret: When your turn starts, give your minions +1/+1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardEadricthePure : MinionCard
    {
        public CardEadricthePure()
        {
            BaseCost = 7;
            BaseAttack = 3;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 504002;
            CardName = "Eadric the Pure";
            CardText = "Battlecry: Change all enemy minions' Attack to 1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardEntertheColiseum : SpellCard
    {
        public CardEntertheColiseum()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 504003;
            CardName = "Enter the Coliseum";
            CardText = "Destroy all minions except each player's highest Attack minion.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Epic;
        }
    }

    class CardMurlocKnight : MinionCard
    {
        public CardMurlocKnight()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 504004;
            CardName = "Murloc Knight";
            CardText = "Inspire: Summon a random Murloc.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardMysteriousChallenger : MinionCard
    {
        public CardMysteriousChallenger()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 504005;
            CardName = "Mysterious Challenger";
            CardText = "Battlecry: Put one of each Secret from your deck into the battlefield.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSealofChampions : SpellCard
    {
        public CardSealofChampions()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 504006;
            CardName = "Seal of Champions";
            CardText = "Give a minion +3 Attack and Divine Shield.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardTuskarrJouster : MinionCard
    {
        public CardTuskarrJouster()
        {
            BaseCost = 5;
            BaseAttack = 5;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 504007;
            CardName = "Tuskarr Jouster";
            CardText = "Battlecry: Reveal a minion in each deck. If yours costs more, restore 7 Health to your hero.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWarhorseTrainer : MinionCard
    {
        public CardWarhorseTrainer()
        {
            BaseCost = 3;
            BaseAttack = 2;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 504008;
            CardName = "Warhorse Trainer";
            CardText = "Your Silver Hand Recruits have +1 Attack.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Paladin;
            CRarity = CardRarity.Common;
        }
    }

    class CardConfessorPaletress : MinionCard
    {
        public CardConfessorPaletress()
        {
            BaseCost = 7;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 505000;
            CardName = "Confessor Paletress";
            CardText = "Inspire: Summon a random Legendary minion.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardConfuse : SpellCard
    {
        public CardConfuse()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 505001;
            CardName = "Confuse";
            CardText = "Swap the Attack and health of all minions.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Epic;
        }
    }

    class CardConvert : SpellCard
    {
        public CardConvert()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 505002;
            CardName = "Convert";
            CardText = "Put a copy of an enemy minion into your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardFlashHeal : SpellCard
    {
        public CardFlashHeal()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 505003;
            CardName = "Flash Heal";
            CardText = "Restore 5 Health.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardHolyChampion : MinionCard
    {
        public CardHolyChampion()
        {
            BaseCost = 4;
            BaseAttack = 3;
            BaseHealth = 5;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 505004;
            CardName = "Holy Champion";
            CardText = "Whenever a character is healed, gain +2 Attack.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardPowerWordGlory : SpellCard
    {
        public CardPowerWordGlory()
        {
            BaseCost = 1;
            RealCost = BaseCost;

            CardId = 505005;
            CardName = "Power Word: Glory";
            CardText = "Choose a minion. Whenever it attacks, restore 4 Health to your hero.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Common;
        }
    }

    class CardShadowfiend : MinionCard
    {
        public CardShadowfiend()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 505006;
            CardName = "Shadowfiend";
            CardText = "Whenever you draw a card, reduce its Cost by (1).";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSpawnofShadows : MinionCard
    {
        public CardSpawnofShadows()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 505007;
            CardName = "Spawn of Shadows";
            CardText = "Inspire: Deal 4 damage to each hero.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWyrmrestAgent : MinionCard
    {
        public CardWyrmrestAgent()
        {
            BaseCost = 2;
            BaseAttack = 1;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 505008;
            CardName = "Wyrmrest Agent";
            CardText = "Battlecry: If you're holding a Dragon, gain +1 Attack and Taunt.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Priest;
            CRarity = CardRarity.Rare;
        }
    }

    class CardAnubarak : MinionCard
    {
        public CardAnubarak()
        {
            BaseCost = 9;
            BaseAttack = 8;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 506000;
            CardName = "Anub’arak";
            CardText = "Deathrattle: Return this to your hand and summon a 4/4 Nerubian.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardBeneaththeGrounds : SpellCard
    {
        public CardBeneaththeGrounds()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 506001;
            CardName = "Beneath the Grounds";
            CardText = "Shuffle 3 Ambushes into your opponent's deck. When drawn, you summon a 4/4 Nerubian.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Epic;
        }
    }

    class CardBuccaneer : MinionCard
    {
        public CardBuccaneer()
        {
            BaseCost = 1;
            BaseAttack = 2;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 506002;
            CardName = "Buccaneer";
            CardText = "Whenever you equip a weapon, give it +1 Attack.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardBurgle : SpellCard
    {
        public CardBurgle()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 506003;
            CardName = "Burgle";
            CardText = "Add 2 random class cards to your hand (from your opponent's class).";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardCutpurse : MinionCard
    {
        public CardCutpurse()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 506004;
            CardName = "Cutpurse";
            CardText = "When this minion attacks the enemy hero, put a Coin into your hand.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardPoisonedBlade : WeaponCard
    {
        public CardPoisonedBlade()
        {
            BaseCost = 4;
            BaseAttack = 1;
            BaseDurability = 3;
            RealCost = BaseCost;

            CardId = 506005;
            CardName = "Poisoned Blade";
            CardText = "Your Hero Power gives this weapon +1 Attack instead of replacing it.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Epic;
        }
    }

    class CardShadoPanCavalry : MinionCard
    {
        public CardShadoPanCavalry()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 506006;
            CardName = "Shado-Pan Cavalry";
            CardText = "Combo: +3 Attack";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardShadyDealer : MinionCard
    {
        public CardShadyDealer()
        {
            BaseCost = 3;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 506007;
            CardName = "Shady Dealer";
            CardText = "Battlecry: If you have a Pirate, gain +1/+1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Rare;
        }
    }

    class CardUndercityValiant : MinionCard
    {
        public CardUndercityValiant()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 506008;
            CardName = "Undercity Valiant";
            CardText = "Combo: Deal 2 damage.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Rogue;
            CRarity = CardRarity.Common;
        }
    }

    class CardAncestralKnowledge : SpellCard
    {
        public CardAncestralKnowledge()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 507000;
            CardName = "Ancestral Knowledge";
            CardText = "Draw 2 cards. Overload: (2)";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardChargedHammer : WeaponCard
    {
        public CardChargedHammer()
        {
            BaseCost = 4;
            BaseAttack = 2;
            BaseDurability = 4;
            RealCost = BaseCost;

            CardId = 507001;
            CardName = "Charged Hammer";
            CardText = "Deathrattle: Your Hero Power becomes 'Deal 2 damage.'";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDraeneiTotemcarver : MinionCard
    {
        public CardDraeneiTotemcarver()
        {
            BaseCost = 4;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 507002;
            CardName = "Draenei Totemcarver";
            CardText = "Battlecry: Gain +1/+1 for each friendly Totem.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardElementalDestruction : SpellCard
    {
        public CardElementalDestruction()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 507003;
            CardName = "Elemental Destruction";
            CardText = "Deal 4-5 damage to all minions. Overload: (5)";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Epic;
        }
    }

    class CardHealingWave : SpellCard
    {
        public CardHealingWave()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 507004;
            CardName = "Healing Wave";
            CardText = "Restore 7 Health. Reveal a minion in each deck. If yours costs more, Restore 14 instead.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardTheMistcaller : MinionCard
    {
        public CardTheMistcaller()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 507005;
            CardName = "The Mistcaller";
            CardText = "Battlecry: Give all minions in your hand and deck +1/+1.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardThunderBluffValiant : MinionCard
    {
        public CardThunderBluffValiant()
        {
            BaseCost = 5;
            BaseAttack = 3;
            BaseHealth = 6;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 507006;
            CardName = "Thunder Bluff Valiant";
            CardText = "Inspire: Give your Totems +2 Attack.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Rare;
        }
    }

    class CardTotemGolem : MinionCard
    {
        public CardTotemGolem()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 507007;
            CardName = "Totem Golem";
            CardText = "Overload: (1)";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardTuskarrTotemic : MinionCard
    {
        public CardTuskarrTotemic()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 507008;
            CardName = "Tuskarr Totemic";
            CardText = "Battlecry: Summon ANY random Totem.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Shaman;
            CRarity = CardRarity.Common;
        }
    }

    class CardDarkBargain : SpellCard
    {
        public CardDarkBargain()
        {
            BaseCost = 6;
            RealCost = BaseCost;

            CardId = 508000;
            CardName = "Dark Bargain";
            CardText = "Destroy 2 random enemy minions. Discard 2 random cards.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Epic;
        }
    }

    class CardDemonfuse : SpellCard
    {
        public CardDemonfuse()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 508001;
            CardName = "Demonfuse";
            CardText = "Give a Demon +3/+3. Give your opponent a Mana Crystal.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardDreadsteed : MinionCard
    {
        public CardDreadsteed()
        {
            BaseCost = 4;
            BaseAttack = 1;
            BaseHealth = 1;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 508002;
            CardName = "Dreadsteed";
            CardText = "Deathrattle: Summon a Dreadsteed.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Epic;
        }
    }

    class CardFearsomeDoomguard : MinionCard
    {
        public CardFearsomeDoomguard()
        {
            BaseCost = 7;
            BaseAttack = 6;
            BaseHealth = 8;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 508003;
            CardName = "Fearsome Doomguard";
            CardText = "";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardFistofJaraxxus : SpellCard
    {
        public CardFistofJaraxxus()
        {
            BaseCost = 4;
            RealCost = BaseCost;

            CardId = 508004;
            CardName = "Fist of Jaraxxus";
            CardText = "When you play or discard this, deal 4 damage to a random enemy.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardTinyKnightofEvil : MinionCard
    {
        public CardTinyKnightofEvil()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 508005;
            CardName = "Tiny Knight of Evil";
            CardText = "";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardVoidCrusher : MinionCard
    {
        public CardVoidCrusher()
        {
            BaseCost = 6;
            BaseAttack = 5;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 508006;
            CardName = "Void Crusher";
            CardText = "Inspire: Destroy a random minion for each player.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Rare;
        }
    }

    class CardWilfredFizzlebang : MinionCard
    {
        public CardWilfredFizzlebang()
        {
            BaseCost = 6;
            BaseAttack = 4;
            BaseHealth = 4;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 508007;
            CardName = "Wilfred Fizzlebang";
            CardText = "Cards you draw with your Hero Power cost (0) mana.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Legendary;
        }
    }

    class CardWrathguard : MinionCard
    {
        public CardWrathguard()
        {
            BaseCost = 2;
            BaseAttack = 4;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 508008;
            CardName = "Wrathguard";
            CardText = "Whenever this minion takes damage, also deal that amount to your hero.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warlock;
            CRarity = CardRarity.Common;
        }
    }

    class CardAlexstraszasChampion : MinionCard
    {
        public CardAlexstraszasChampion()
        {
            BaseCost = 2;
            BaseAttack = 2;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 509000;
            CardName = "Alexstrasza’s Champion";
            CardText = "Battlecry: If you're holding a Dragon, gain +1 Attack and Charge.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardBash : SpellCard
    {
        public CardBash()
        {
            BaseCost = 3;
            RealCost = BaseCost;

            CardId = 509001;
            CardName = "Bash";
            CardText = "Deal 3 Damage. Gain 3 Armor.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardBolster : SpellCard
    {
        public CardBolster()
        {
            BaseCost = 2;
            RealCost = BaseCost;

            CardId = 509002;
            CardName = "Bolster";
            CardText = "Give your Taunt minions +2/+2.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardKingsDefender : WeaponCard
    {
        public CardKingsDefender()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseDurability = 2;
            RealCost = BaseCost;

            CardId = 509003;
            CardName = "King’s Defender";
            CardText = "Battlecry: If you have a minion with Taunt, gain +1 durability.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardMagnataurAlpha : MinionCard
    {
        public CardMagnataurAlpha()
        {
            BaseCost = 4;
            BaseAttack = 5;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 509004;
            CardName = "Magnataur Alpha";
            CardText = "Also damage the minions next to whomever he attacks.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Epic;
        }
    }

    class CardOrgrimmarAspirant : MinionCard
    {
        public CardOrgrimmarAspirant()
        {
            BaseCost = 3;
            BaseAttack = 3;
            BaseHealth = 3;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 509005;
            CardName = "Orgrimmar Aspirant";
            CardText = "Inspire: Give your weapon +1 Attack.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Common;
        }
    }

    class CardSeaReaver : MinionCard
    {
        public CardSeaReaver()
        {
            BaseCost = 6;
            BaseAttack = 6;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 509006;
            CardName = "Sea Reaver";
            CardText = "When you draw this, deal 1 damage to all YOUR minions.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Epic;
        }
    }

    class CardSparringPartner : MinionCard
    {
        public CardSparringPartner()
        {
            BaseCost = 2;
            BaseAttack = 3;
            BaseHealth = 2;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 509007;
            CardName = "Sparring Partner";
            CardText = "Taunt Battlecry: Give a minion Taunt.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Rare;
        }
    }

    class CardVarianWrynn : MinionCard
    {
        public CardVarianWrynn()
        {
            BaseCost = 10;
            BaseAttack = 7;
            BaseHealth = 7;
            RealCost = BaseCost;
            RealAttack = BaseAttack;
            RealHealth = BaseHealth;

            CardId = 509008;
            CardName = "Varian Wrynn";
            CardText = "Battlecry: Draw 3 cards. Put any minions you drew directly into the battlefield.";
            CSet = CardSet.Tournament;
            CClass = CardClass.Warrior;
            CRarity = CardRarity.Legendary;
        }
    }




}
