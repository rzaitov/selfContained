//
//  ViewController.m
//  UISegmentedControl
//
//  Created by Rustam on 17/08/2015.
//  Copyright © 2015 Rustam. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
//    UISegmentedControl * controll = [[UISegmentedControl alloc] initWithItems:@[@"first", @"second"]];

//    UIImage * firstImg = [UIImage imageNamed:@"first"];
//    UIImage * secondImg = [UIImage imageNamed:@"second"];
//    UISegmentedControl * controll = [[UISegmentedControl alloc] initWithItems:@[firstImg, secondImg]];
    
    UIImage * firstImg = [UIImage imageNamed:@"first"];
    UIImage * secondImg = [UIImage imageNamed:@"second"];
    UISegmentedControl * controll = [[UISegmentedControl alloc] initWithItems:@[@"first", secondImg]];

    
    [self.view addSubview:controll];
    controll.center = self.view.center;
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
