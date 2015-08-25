//
//  ViewController.m
//  CustomView
//
//  Created by Rustam on 25/08/2015.
//  Copyright © 2015 Rustam. All rights reserved.
//

#import "ViewController.h"
#import "CustomView.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    CustomView * view = (CustomView *)self.view;
    NSLog(@"%@", [view LeftView]);
    NSLog(@"%@", [view RightView]);
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
