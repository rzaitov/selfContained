//
//  ViewController.m
//  NSStringEqualsTest
//
//  Created by Rustam on 18/07/2015.
//  Copyright © 2015 Rustam. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    
    NSString *a = @"a";
    NSString *b = @"b";
    
    if([a isEqualToString:b])
        NSLog(@"equal");
    else
        NSLog(@"not equal");
    
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
