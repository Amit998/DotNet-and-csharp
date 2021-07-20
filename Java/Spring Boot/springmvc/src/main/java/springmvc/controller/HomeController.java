package springmvc.controller;

import java.util.*;
import java.util.ArrayList;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;

@Controller
/* @RequestMapping("/first") */
public class HomeController {


	
	@RequestMapping(path="/home",method = RequestMethod.GET)
	public String index(Model model) {
		model.addAttribute("name","Amit Dutta");
		model.addAttribute("id",111);
		
		List<String> namesList = new ArrayList<String>();
	
		namesList.add("A");
		namesList.add("B");
		namesList.add("C");
		model.addAttribute("names",namesList);
		
		System.out.println("This is home");
		return "index";
	}
	
	@RequestMapping("/help")
	public ModelAndView help() {
		
		
		ModelAndView modelAndView=new ModelAndView();
		
		modelAndView.addObject("name","amit");
		modelAndView.setViewName("help");

		System.out.println("this is help");
			
		return modelAndView;
	}
	
	@RequestMapping("/about")
	public String about() {
		System.out.println("This is about");
		return "about";
	}
	
	
	
	


}
