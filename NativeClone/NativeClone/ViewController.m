//
//  ViewController.m
//  NativeClone
//
//  Created by Rustam on 18/08/2015.
//  Copyright © 2015 Rustam. All rights reserved.
//

#import "ViewController.h"
#import <CoreGraphics/CoreGraphics.h>

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    
    UICollectionViewLayoutAttributes* a1 = [[UICollectionViewLayoutAttributes alloc] init];
    a1.center = CGPointMake(1, 2);
    UICollectionViewLayoutAttributes* a2 = [[UICollectionViewLayoutAttributes alloc] init];
    a2.center = CGPointMake(1, 2);
    
    NSLog(@"%d", [a1 isEqual:a2]);
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
