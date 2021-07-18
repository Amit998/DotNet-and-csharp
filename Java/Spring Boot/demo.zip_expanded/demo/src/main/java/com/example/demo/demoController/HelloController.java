package com.example.demo.demoController;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {
	
	@RequestMapping("/display")
	@ResponseBody
	public String Display() {
		
		return "Hello World";
	}
	
	@RequestMapping("/")
	@ResponseBody
	public String Home() {
		
		return "Home Page";
	}
	
	@RequestMapping("/")
	@ResponseBody
	public int Calculate() {
		int a=10;
		
		return a+a+a;
	}
}
