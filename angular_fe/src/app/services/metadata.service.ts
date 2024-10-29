import { Injectable } from '@angular/core';
import { Meta, MetaDefinition } from '@angular/platform-browser';

/**
 * @class MetadataService
 * @description A service that gives ability to change project metadata.
 * 
 * @function generateMetadata generates page's title and description
 * 
 * @function generateProjectMetadata generates project's metadata (to implement)
 */

@Injectable({
  providedIn: 'root'
})
export class MetadataService {

  tags: MetaDefinition[] = [];

  constructor(private meta: Meta) { }

  /**
   * 
   * @param passedTags array of tags to generate metadata provided as array of `MetaDefinition`.
   * 
   * Example tag: `{name: 'title', content: 'HomePage'}`
   */

  generateMetadata(passedTags: MetaDefinition[]) {
    passedTags.forEach((tag) => {
      const existingTag = this.meta.getTag(`name=${tag.name}`);
      if (existingTag) {
        this.meta.updateTag(tag);
      } else {
        this.meta.addTag(tag);
      }
    });
  }
}
