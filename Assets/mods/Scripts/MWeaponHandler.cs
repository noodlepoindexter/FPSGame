using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MWeaponHandler : WeaponHandler {

    // private Animator anim;

    // public WeaponAim weapon_Aim;

    // [SerializeField]
    // private GameObject muzzleFlash;

    // [SerializeField]
    // private AudioSource shootSound, reload_Sound;

    // public WeaponFireType fireType;

    // public WeaponBulletType bulletType;

    // public GameObject attack_Point;

    [SerializeField] private string shootAnimationStateName;

    void Awake() {
        anim = GetComponent<Animator>();
    }

    public override void ShootAnimation() {
        Debug.Log("Playing shoot animation: " + shootAnimationStateName);
        anim.Play(shootAnimationStateName, 0, 0f);
        // anim.SetTrigger(AnimationTags.SHOOT_TRIGGER);
    }

    public void Aim(bool canAim) {
        anim.SetBool(AnimationTags.AIM_PARAMETER, canAim);
    }

    void Turn_On_MuzzleFlash() {
        muzzleFlash.SetActive(true);
    }

    void Turn_Off_MuzzleFlash() {
        muzzleFlash.SetActive(false);
    }

    void Play_ShootSound() {
        shootSound.Play();
    }

    void Play_ReloadSound() {
        reload_Sound.Play();
    }

    void Turn_On_AttackPoint() {
        attack_Point.SetActive(true);
    }

    void Turn_Off_AttackPoint() {
        if(attack_Point.activeInHierarchy) {
            attack_Point.SetActive(false);
        }
    }

} // class





































