// '©  2014 MRI Software LLC.  All rights reserved.  Unauthorized reproduction is a violation of applicable law.
// 'This material contains certain confidential or proprietary information or trade secrets of MRI Software LLC.
// 

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Coypu;
using Coypu.Actions;
using Coypu.Drivers;
using Coypu.Queries;

namespace CoypuTables {

  public abstract class DelegatingElementScope : Element, Scope {

    private readonly ElementScope innerElement;

    protected DelegatingElementScope(ElementScope innerElement) {
      this.innerElement = innerElement;
    }

    public string Id {
      get { return innerElement.Id; }
    }

    public string Text {
      get { return innerElement.Text; }
    }

    public string Value {
      get { return innerElement.Value; }
    }

    public string Name {
      get { return innerElement.Name; }
    }

    public string SelectedOption {
      get { return innerElement.SelectedOption; }
    }

    public bool Selected {
      get { return innerElement.Selected; }
    }

    public object Native {
      get { return innerElement.Native; }
    }

    public string this[string attributeName] {
      get { return innerElement[attributeName]; }
    }

    public string OuterHTML {
      get { return innerElement.OuterHTML; }
    }

    public string InnerHTML {
      get { return innerElement.InnerHTML; }
    }

    public string Title {
      get { return innerElement.Title; }
    }

    public bool Disabled {
      get { return innerElement.Disabled; }
    }

    public State FindState(State[] states, Options options = null) {
      return innerElement.FindState(states, options);
    }

    public Scope ClickButton(string locator, PredicateQuery until, Options options) {
      return innerElement.ClickButton(locator, until, options);
    }

    public Scope ClickLink(string locator, PredicateQuery until, Options options) {
      return innerElement.ClickLink(locator, until, options);
    }

    public Element Now() {
      return innerElement.Now();
    }

    public bool HasCss(string cssSelector, string text, Options options = null) {
      return innerElement.HasCss(cssSelector, text, options);
    }

    public bool HasCss(string cssSelector, Regex text, Options options = null) {
      return innerElement.HasCss(cssSelector, text, options);
    }

    public bool HasXPath(string xpath, Options options = null) {
      return innerElement.HasXPath(xpath, options);
    }

    public bool HasNoCss(string cssSelector, string text, Options options = null) {
      return innerElement.HasNoCss(cssSelector, text, options);
    }

    public bool HasNoCss(string cssSelector, Regex text, Options options = null) {
      return innerElement.HasNoCss(cssSelector, text, options);
    }

    public bool HasNoXPath(string xpath, Options options = null) {
      return innerElement.HasNoXPath(xpath, options);
    }

    public Uri Location {
      get { return innerElement.Location; }
    }

    public Browser Browser {
      get { return innerElement.Browser; }
    }

    public DriverScope OuterScope {
      get { return innerElement.OuterScope; }
    }

    public State FindState(params State[] states) {
      return innerElement.FindState(states);
    }

    public void ClickButton(string locator, Options options = null) {
      ((Scope) innerElement).ClickButton(locator, options);
    }

    public void ClickLink(string locator, Options options = null) {
      ((Scope) innerElement).ClickLink(locator, options);
    }

    public ElementScope FindButton(string locator, Options options = null) {
      return ((Scope) innerElement).FindButton(locator, options);
    }

    public ElementScope FindLink(string locator, Options options = null) {
      return ((Scope) innerElement).FindLink(locator, options);
    }

    public ElementScope FindField(string locator, Options options = null) {
      return ((Scope) innerElement).FindField(locator, options);
    }

    public FillInWith FillIn(string locator, Options options = null) {
      return ((Scope) innerElement).FillIn(locator, options);
    }

    public SelectFrom Select(string option, Options options = null) {
      return ((Scope) innerElement).Select(option, options);
    }

    public bool HasContent(string text, Options options = null) {
      return ((Scope) innerElement).HasContent(text, options);
    }

    public bool HasContentMatch(Regex pattern, Options options = null) {
      return ((Scope) innerElement).HasContentMatch(pattern, options);
    }

    public bool HasNoContent(string text, Options options = null) {
      return ((Scope) innerElement).HasNoContent(text, options);
    }

    public bool HasNoContentMatch(Regex pattern, Options options = null) {
      return ((Scope) innerElement).HasNoContentMatch(pattern, options);
    }

    public ElementScope FindCss(string cssSelector, Options options = null) {
      return ((Scope) innerElement).FindCss(cssSelector, options);
    }

    public ElementScope FindCss(string cssSelector, string text, Options options = null) {
      return ((Scope) innerElement).FindCss(cssSelector, text, options);
    }

    public ElementScope FindCss(string cssSelector, Regex text, Options options = null) {
      return ((Scope) innerElement).FindCss(cssSelector, text, options);
    }

    public ElementScope FindXPath(string xpath, Options options = null) {
      return ((Scope) innerElement).FindXPath(xpath, options);
    }

    public IEnumerable<SnapshotElementScope> FindAllCss(string cssSelector, Func<IEnumerable<SnapshotElementScope>, bool> predicate = null, Options options = null) {
      return ((Scope) innerElement).FindAllCss(cssSelector, predicate, options);
    }

    public IEnumerable<SnapshotElementScope> FindAllXPath(string xpath, Func<IEnumerable<SnapshotElementScope>, bool> predicate = null, Options options = null) {
      return ((Scope) innerElement).FindAllXPath(xpath, predicate, options);
    }

    public ElementScope FindSection(string locator, Options options = null) {
      return ((Scope) innerElement).FindSection(locator, options);
    }

    public ElementScope FindFieldset(string locator, Options options = null) {
      return ((Scope) innerElement).FindFieldset(locator, options);
    }

    public ElementScope FindFrame(string locator, Options options = null) {
      return ((Scope) innerElement).FindFrame(locator, options);
    }

    public ElementScope FindId(string id, Options options = null) {
      return ((Scope) innerElement).FindId(id, options);
    }

    public ElementScope FindIdEndingWith(string endsWith, Options options = null) {
      return ((Scope) innerElement).FindIdEndingWith(endsWith, options);
    }

    public void Check(string locator, Options options = null) {
      ((Scope) innerElement).Check(locator, options);
    }

    public void Uncheck(string locator, Options options = null) {
      ((Scope) innerElement).Uncheck(locator, options);
    }

    public void Choose(string locator, Options options = null) {
      ((Scope) innerElement).Choose(locator, options);
    }

    public void RetryUntilTimeout(Action action, Options options = null) {
      ((Scope) innerElement).RetryUntilTimeout(action, options);
    }

    public void RetryUntilTimeout(BrowserAction action) {
      ((Scope) innerElement).RetryUntilTimeout(action);
    }

    public TResult RetryUntilTimeout<TResult>(Func<TResult> function, Options options = null) {
      return ((Scope) innerElement).RetryUntilTimeout<TResult>(function, options);
    }

    public T Query<T>(Query<T> query) {
      return ((Scope) innerElement).Query<T>(query);
    }

    public T Query<T>(Func<T> query, T expecting, Options options = null) {
      return ((Scope) innerElement).Query<T>(query, expecting, options);
    }

    public void TryUntil(Action tryThis, Func<bool> until, TimeSpan waitBeforeRetry, Options options = null) {
      innerElement.TryUntil(tryThis, until, waitBeforeRetry, options);
    }

    public void TryUntil(BrowserAction tryThis, PredicateQuery until, Options options) {
      innerElement.TryUntil(tryThis, until, options);
    }

    public void Check(string locator) {
      innerElement.Check(locator);
    }

    public void Choose(string locator) {
      innerElement.Choose(locator);
    }

    public void ClickLink(string locator) {
      innerElement.ClickLink(locator);
    }

    public FillInWith FillIn(string locator) {
      return innerElement.FillIn(locator);
    }

    public IEnumerable<Element> FindAllCss(string cssSelector) {
      return innerElement.FindAllCss(cssSelector);
    }

    public IEnumerable<Element> FindAllXPath(string xpath) {
      return innerElement.FindAllXPath(xpath);
    }

    public ElementScope FindButton(string locator) {
      return innerElement.FindButton(locator);
    }

    public ElementScope FindCss(string cssSelector) {
      return innerElement.FindCss(cssSelector);
    }

    public ElementScope FindField(string locator) {
      return innerElement.FindField(locator);
    }

    public ElementScope FindFieldset(string locator) {
      return innerElement.FindFieldset(locator);
    }

    public ElementScope FindId(string id) {
      return innerElement.FindId(id);
    }

    public ElementScope FindLink(string locator) {
      return innerElement.FindLink(locator);
    }

    public ElementScope FindSection(string locator) {
      return innerElement.FindSection(locator);
    }

    public ElementScope FindXPath(string xpath) {
      return innerElement.FindXPath(xpath);
    }

    public bool HasContent(string text) {
      return innerElement.HasContent(text);
    }

    public bool HasContentMatch(Regex pattern) {
      return innerElement.HasContentMatch(pattern);
    }

    public bool HasNoContent(string text) {
      return innerElement.HasNoContent(text);
    }

    public bool HasNoContentMatch(Regex pattern) {
      return innerElement.HasNoContentMatch(pattern);
    }

    public bool HasNoXPath(string xpath) {
      return innerElement.HasNoXPath(xpath);
    }

    public bool HasXPath(string xpath) {
      return innerElement.HasXPath(xpath);
    }

    public ElementScope Hover(Options options) {
      return innerElement.Hover(options);
    }

    public T Query<T>(Func<T> query, T expecting) {
      return innerElement.Query(query, expecting);
    }

    public TResult RetryUntilTimeout<TResult>(Func<TResult> function) {
      return innerElement.RetryUntilTimeout(function);
    }

    public void RetryUntilTimeout(DriverAction driverAction) {
      innerElement.RetryUntilTimeout(driverAction);
    }

    public void RetryUntilTimeout(Action action) {
      innerElement.RetryUntilTimeout(action);
    }

    public SelectFrom Select(string option) {
      return innerElement.Select(option);
    }

    public void Uncheck(string locator) {
      innerElement.Uncheck(locator);
    }

    public bool Exists() {
      return innerElement.Exists();
    }

    public bool Missing() {
      return innerElement.Missing();
    }

  }

}